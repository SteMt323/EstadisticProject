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
using EstadisticProject.Views.ViewsModels.TableFrecuenciesLoads;

namespace EstadisticProject.Views.ViewsModels
{
    public partial class TableFrecuencies : UserControl
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
        public TableFrecuencies()
        {
            InitializeComponent();
        }

        private void TableFrecuencies_Load(object sender, EventArgs e)
        {
            iconButton1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, iconButton1.Width, iconButton1.Height, 30, 30));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SearchData searchData = new SearchData();
            searchData.ShowDialog();
        }
    }
}
