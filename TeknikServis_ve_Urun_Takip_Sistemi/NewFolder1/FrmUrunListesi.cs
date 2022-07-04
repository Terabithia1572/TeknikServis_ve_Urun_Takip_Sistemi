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
    public partial class FrmUrunListesi : DevExpress.XtraEditors.XtraForm
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            //Listeleme ToList Add Remove

            var degerler = db.Tbl_Urun.ToList();
            dgv_UrunListesi.DataSource = degerler;

        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}