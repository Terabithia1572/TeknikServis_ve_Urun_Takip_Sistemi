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
    public partial class frmArizaListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmArizaListesi()
        {
            InitializeComponent();
        }

        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void frmArizaListesi_Load(object sender, EventArgs e)
        {

            var degerler = (from x in db.Tbl_UrunKabul
                            select new
                            {
                                x.islemID,
                                CariAd = x.Tbl_Cari.Ad+" "+x.Tbl_Cari.Soyad,
                                PersonelAd = x.Tbl_Personel.Ad+" "+x.Tbl_Personel.Soyad,
                                x.GelisTarih,
                                x.CikisTarih,
                                x.UrunSeriNo
                            });
            dgv_ArizaUrunListesi.DataSource = degerler.ToList();
        }
    }
}