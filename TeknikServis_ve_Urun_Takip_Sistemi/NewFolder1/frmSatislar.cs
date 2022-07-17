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
    public partial class frmSatislar : DevExpress.XtraEditors.XtraForm
    {
        public frmSatislar()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void frmSatislar_Load(object sender, EventArgs e)
        {
            Tbl_Hareket tbl_Hareket = new Tbl_Hareket();
            var listele = (from x in db.Tbl_Hareket
                           select new
                           {
                               x.hareketID,
                               x.Tbl_Urun.Ad,
                               Musteri = x.Tbl_Cari.Ad+" "+x.Tbl_Cari.Soyad,
                               Personel = x.Tbl_Personel.Ad+" "+x.Tbl_Personel.Soyad,
                               x.Tarih,
                               x.Adet,
                               x.Fiyat,
                               x.UrunSeriNo
                           });
            dgv_SatislarListesi.DataSource = listele.ToList();

        }
    }
}