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

namespace EstadisticProject.Views.ViewsModels.HistorialCards
{
    public partial class HistorialCard : UserControl
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
        public HistorialCard()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        public void SetData(string fecha, string accion, string estado)
        {
            label_fecha.Text = fecha;
            label_accion.Text = accion;
            label_estado.Text = estado;
        }

        private void HistorialCard_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
        }
    }
}
