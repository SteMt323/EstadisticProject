using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace EstadisticProject.Views.ViewsModels
{
    public partial class Cargar_Datos : UserControl
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,      // X-coordinate of upper-left corner
        int nTopRect,       // Y-coordinate of upper-left corner
        int nRightRect,     // X-coordinate of lower-right corner
        int nBottomRect,    // Y-coordinate of lower-right corner
        int nWidthEllipse,  // width of ellipse
        int nHeightEllipse  // height of ellipse
        );

        private string rutaArchivoTemporal = string.Empty;

        public Cargar_Datos()
        {
            InitializeComponent();
        }

        private void Cargar_Datos_Load(object sender, EventArgs e)
        {
            btn_adjuntar_archivo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_adjuntar_archivo.Width, btn_adjuntar_archivo.Height, 30, 30));
            btn_guardar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_guardar.Width, btn_guardar.Height, 30, 30));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 30, 30));
        }

        private void txt_datos_manuales_Enter(object sender, EventArgs e)
        {
            if (txt_datos_manuales.Text == "Ingresar Manualmente (separado por comas)")
            {
                txt_datos_manuales.Text = "";
                txt_datos_manuales.ForeColor = Color.LightGray;
            }
        }

        private void txt_datos_manuales_Leave(object sender, EventArgs e)
        {
            if (txt_datos_manuales.Text == "")
            {
                txt_datos_manuales.Text = "Ingresar Manualmente (separado por comas)";
                txt_datos_manuales.ForeColor = Color.DimGray;
            }
        }

        private void btn_adjuntar_archivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
                openFileDialog.Title = "Seleccionar archivo CSV";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Guarda la ruta completa del archivo original
                    rutaArchivoTemporal = openFileDialog.FileName;

                    // Muestra solo el nombre del archivo
                    lbl_ruta.Text = Path.GetFileName(rutaArchivoTemporal);
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Ruta del proyecto base
            string rutaProyecto = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
            string rutaDestino = Path.Combine(rutaProyecto, "AppData", "ProcessedFiles");
            string rutaHistorial = Path.Combine(rutaProyecto, "AppData", "CacheH");
            string rutaHistorialArchivo = Path.Combine(rutaHistorial, "Historial.json");

            try
            {
                Directory.CreateDirectory(rutaDestino);
                Directory.CreateDirectory(rutaHistorial);

                bool success = false;
                string tipoAction = "";

                // ⚠️ Si el usuario adjuntó un archivo CSV
                if (!string.IsNullOrEmpty(rutaArchivoTemporal) && File.Exists(rutaArchivoTemporal))
                {
                    string nombreArchivo = Path.GetFileName(rutaArchivoTemporal);
                    string rutaArchivoFinal = Path.Combine(rutaDestino, nombreArchivo);

                    File.Copy(rutaArchivoTemporal, rutaArchivoFinal, true);

                    string[] lineas = File.ReadAllLines(rutaArchivoFinal);
                    txt_datos.Clear();
                    foreach (string linea in lineas)
                    {
                        txt_datos.AppendText(linea + Environment.NewLine);
                    }

                    success = true;
                    tipoAction = "Carga de Datos";

                    MessageBox.Show("Archivo CSV guardado y cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Si NO hay archivo pero sí hay datos ingresados manualmente
                else if (!string.IsNullOrWhiteSpace(txt_datos_manuales.Text) &&
                         txt_datos_manuales.Text.Trim() != "Ingresar Manualmente (separado por comas)")
                {
                    
                    string fechaHora = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                    string nombreGenerado = $"datos_usuario_{fechaHora}.csv";
                    string rutaManualFinal = Path.Combine(rutaDestino, nombreGenerado);

                    string[] datosSeparados = txt_datos_manuales.Text.Trim().Split(',');

                    // Validacion para determinar si los datos son numéricos

                    bool datosValidos = datosSeparados.All(d => double.TryParse(d.Trim(), out _));
                    if (!datosValidos)
                    {
                        MessageBox.Show("Todos los datos ingresados manualmente deben ser numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    // Guarda el contenido del TextBox en formato CSV
                    File.WriteAllLines(rutaManualFinal, datosSeparados.Select(d => d.Trim()));

                    // Muestra en txt_datos
                    txt_datos.Clear();
                    foreach (string dato in datosSeparados)
                    {
                        txt_datos.AppendText(dato.Trim() + Environment.NewLine);
                    }
                    success = true;
                    tipoAction = "Carga de Datos Manuales";

                    MessageBox.Show("Datos manuales guardados correctamente en un archivo CSV.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se adjuntó un archivo ni se ingresaron datos manuales válidos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Registrar en historial (si hubo una acción, exitosa o fallida)
                if (!string.IsNullOrEmpty(tipoAction))
                {
                    var nuevoRegistro = new
                    {
                        fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        accion = tipoAction,
                        estado = success ? "Exito" : "Fallido"
                    };

                    List<object> historial = new List<object>();

                    // Si el historial ya existe, leerlo y deserializarlo
                    if (File.Exists(rutaHistorialArchivo))
                    {
                        string contenidoExistente = File.ReadAllText(rutaHistorialArchivo);
                        if (!string.IsNullOrWhiteSpace(contenidoExistente))
                        {
                            historial = JsonSerializer.Deserialize<List<object>>(contenidoExistente);
                        }
                    }

                    // Agregar el nuevo registro
                    historial.Add(nuevoRegistro);

                    // Volver a guardar todo el historial
                    string jsonActualizado = JsonSerializer.Serialize(historial, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(rutaHistorialArchivo, jsonActualizado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
