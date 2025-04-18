﻿using EstadisticProject.Views.ViewsModels.HistorialCards;
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
    public partial class documentation : UserControl
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

        public class HistorialEntry
        {
            public string fecha { get; set; }
            public string accion { get; set; }
            public string estado { get; set; }
        }
        public documentation()
        {
            InitializeComponent();
            CargarHistorialDashboard();
        }

        private void documentation_Load(object sender, EventArgs e)
        {
            btn_colaboradores.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_colaboradores.Width, btn_colaboradores.Height, 30, 30));
            btn_objetivo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_objetivo.Width, btn_objetivo.Height, 30, 30));
            panel_time.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_time.Width, panel_time.Height, 30, 30));
            flp_historial.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flp_historial.Width, flp_historial.Height, 30, 30));
            timer1.Interval = 1000; // 1 segundo
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void AgregarHistorial(string fecha, string accion, string estado)
        {
            HistorialCard card = new HistorialCard();
            card.SetData(fecha, accion, estado);
            flp_historial.Controls.Add(card);
        }

        private void CargarHistorialDashboard()
        {
            string rutaProyecto = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
            string rutaHistorial = Path.Combine(rutaProyecto, "AppData", "CacheH", "Historial.json");

            if (File.Exists(rutaHistorial))
            {
                string json = File.ReadAllText(rutaHistorial);

                List<HistorialEntry> historial = JsonSerializer.Deserialize<List<HistorialEntry>>(json);

                // Tomar los 2 últimos registros
                var ultimos = historial.OrderByDescending(e => e.fecha).Take(2);

                flp_historial.Controls.Clear();

                foreach (var entrada in ultimos)
                {
                    AgregarHistorial(entrada.fecha, entrada.accion, entrada.estado == "Exito" ? "✔ Exito" : "✖ Error");
                }
            }
            else
            {
                // Si no hay historial, opcionalmente mostrar algo por defecto
                AgregarHistorial(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), "Sin historial aún", "—");
            }
        }
    }
}
