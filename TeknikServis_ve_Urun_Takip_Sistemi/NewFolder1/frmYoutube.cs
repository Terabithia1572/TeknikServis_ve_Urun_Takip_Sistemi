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
    public partial class frmYoutube : DevExpress.XtraEditors.XtraForm
    {
        public frmYoutube()
        {
            InitializeComponent();
        }

        private void frmYoutube_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/");
        }
    }
}