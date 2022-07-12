using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis_ve_Urun_Takip_Sistemi.NewFolder1
{
    public partial class frmCariILLER : DevExpress.XtraEditors.XtraForm
    {
        public frmCariILLER()
        {
            InitializeComponent();
        }

        private void frmCariILLER_Load(object sender, EventArgs e)
        {
            chartControl1.Series["Series 1"].Points.AddPoint("Van", 10);
            chartControl1.Series["Series 1"].Points.AddPoint("Hakkari", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("Şırnak", 6);
            chartControl1.Series["Series 1"].Points.AddPoint("Adıyaman", 5);
            chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 3);
            chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 7);
           
        }
    }
}