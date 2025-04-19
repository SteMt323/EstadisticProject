using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadisticProject.Views.ViewsModels.TableFrecuenciesLoads
{
    public partial class SearchData : Form
    {
        public string ArchivoSeleccionado { get; private set; } = "";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,      // X-coordinate of upper-left corner
        int nTopRect,       // Y-coordinate of upper-left corner
        int nRightRect,     // X-coordinate of lower-right corner
        int nBottomRect,    // Y-coordinate of lower-right corner
        int nWidthEllipse,  // width of ellipse
        int nHeightEllipse  // height of ellipse
        );

        // Funciones para mover la ventana
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para simular el "drag" del formulario
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;



        private void CargarArchivos()
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            // Rutas
            string rutaProyecto = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
            string rutaDestino = Path.Combine(rutaProyecto, "AppData", "ProcessedFiles");

            // Validar si la carpeta existe
            if (Directory.Exists(rutaDestino))
            {
                // Obtener todos los archivos de la carpeta
                string[] archivos = Directory.GetFiles(rutaDestino);

                dataGridView1.Rows.Clear();

                // Agregar cada archivo como una fila
                foreach (string archivo in archivos)
                {
                    string nombreArchivo = Path.GetFileName(archivo);
                    dataGridView1.Rows.Add(nombreArchivo);
                }
                
            }
            else
            {
                MessageBox.Show("No hay datos registrados...");
            }
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        public SearchData()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.MouseDown += Form_MouseDown;
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchData_Load(object sender, EventArgs e)
        {
            CargarArchivos();
            dataGridView1.ClearSelection();
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dataGridView1.SelectedRows[0];
                
                label1.Text = filaSeleccionada.Cells[0].Value != null ? filaSeleccionada.Cells[0].Value.ToString() : "N/A";
            }
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(label1.Text) && label1.Text != "File Name...")
            {
                ArchivoSeleccionado = label1.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona un archivo antes de continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
