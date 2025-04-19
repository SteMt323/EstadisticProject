using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EstadisticProject.Views.ViewsModels.TableFrecuenciesLoads
{
    public partial class TableContainer : UserControl
    {
        private string archivoCSV;
        public TableContainer(string nombreArchivo)
        {
            InitializeComponent();
            archivoCSV = nombreArchivo;
            CargarYCalcularDatos();
        }

        private void CargarYCalcularDatos()
        {
            string rutaProyecto = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
            string rutaArchivo = Path.Combine(rutaProyecto, "AppData", "ProcessedFiles", archivoCSV);

            // Verificar si el archivo existe
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<double> datos = new List<double>();

            // Leer el archivo CSV
            using (StreamReader reader = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    if (double.TryParse(linea.Trim(), out double valor))
                    {
                        datos.Add(valor);
                    }
                }
            }

            if (datos.Count == 0)
            {
                MessageBox.Show("El archivo no contiene datos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            datos.Sort();

            int N = datos.Count;
            double K = Math.Ceiling(Math.Sqrt(N));
            double R = datos.Max() - datos.Min();

            // Calcular U
            int maxDecimales = datos.Select(x => BitConverter.GetBytes(decimal.GetBits((decimal)x)[3])[2]).Max();
            double U = (maxDecimales > 0) ? Math.Pow(10, -maxDecimales) : 1;

            double C = Math.Ceiling((R / K + U) * 1000) / 1000; // Redondeado a 3 decimales

            double Li = datos.Min();
            double Ls;
            double X;

            double fi;
            double Fr;
            double Fii = 0;
            double Fra = 0;



            dataGridView1.Rows.Clear();

            for (int i = 0; i < K; i++)
            {
                Ls = Math.Round(Li + C - U, 3);
                X = Math.Round((Li + Ls) / 2, 3);

                fi = datos.Count(x => x >= Li && x < Li + C);
                if (i == K - 1) // último intervalo incluye el max
                    fi = datos.Count(x => x >= Li && x <= Ls + U);

                Fr = Math.Round((fi / N) * 100, 2);
                Fii += fi;
                Fra += Fr;

                dataGridView1.Rows.Add(
                    i + 1,
                    Li.ToString("0.###"),
                    Ls.ToString("0.###"),
                    X.ToString("0.###"),
                    fi,
                    Fr.ToString("0.##") + "%",
                    Fii,
                    Fra.ToString("0.##") + "%"
                );

                Li += C;
            }

            // Calcular sumatorias
            int sumaFi = 0;
            double sumaFr = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null && int.TryParse(row.Cells[4].Value.ToString(), out int fiAux))
                    sumaFi += fiAux;

                if (row.Cells[5].Value != null && double.TryParse(row.Cells[5].Value.ToString().Replace("%", ""), out double fr))
                {
                    sumaFr += fr;
                }
            }

            // Crear fila de totales
            DataGridViewRow filaTotal = new DataGridViewRow();
            filaTotal.CreateCells(dataGridView1);

            // Masivo bro
            filaTotal.Cells[0].Value = "";                // K
            filaTotal.Cells[1].Value = "";                // Li
            filaTotal.Cells[2].Value = "";                // Ls
            filaTotal.Cells[3].Value = "Total";           // X o dejarlo vacío también
            filaTotal.Cells[4].Value = sumaFi.ToString(); // fi total
            filaTotal.Cells[5].Value = sumaFr.ToString("0.00") + "%"; // Fr (%) total
            filaTotal.Cells[6].Value = "";                // Fi
            filaTotal.Cells[7].Value = "";                // Fra (%)

            dataGridView1.Rows.Add(filaTotal);
            filaTotal.DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 153); // Amarillo masivo muejejejejujee
            filaTotal.DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            filaTotal.DefaultCellStyle.ForeColor = Color.Black;

        }
    }
}
