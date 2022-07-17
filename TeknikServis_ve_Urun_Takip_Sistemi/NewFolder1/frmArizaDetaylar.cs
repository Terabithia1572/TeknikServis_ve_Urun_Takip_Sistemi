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
    public partial class frmArizaDetaylar : DevExpress.XtraEditors.XtraForm
    {
        public frmArizaDetaylar()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Tbl_ArizaDetay arizaDetay = new Tbl_ArizaDetay();

        }
    }
}