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
    public partial class UrunIstatistik : DevExpress.XtraEditors.XtraForm
    {
        public UrunIstatistik()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();

        private void UrunIstatistik_Load(object sender, EventArgs e)
        {
            lbl_ToplamUrunSayisi.Text = db.Tbl_Urun.Count().ToString();
            lbl_ToplamKategoriSayisi.Text = db.Tbl_Kategori.Count().ToString();
            lbl_ToplamStokSayisi.Text = db.Tbl_Urun.Sum(x => x.Stok).ToString();
            lbl_EnFazlaStokluUrun.Text = (from i in db.Tbl_Urun
                                             orderby i.Stok descending
                                             select i.Ad).FirstOrDefault();
            lbl_EnAzStokluUrun.Text = (from x in db.Tbl_Urun
                                       orderby x.Stok ascending
                                       select x.Ad).FirstOrDefault();
            Random r = new Random();
            int sayi = r.Next(1, 10);
            lbl_KritikSeviye.Text = (sayi).ToString();
            lbl_EnYuksekFiyatliUrun.Text = (from x in db.Tbl_Urun
                                            orderby x.SatisFiyat descending
                                            select x.Ad).FirstOrDefault();

            lbl_EnAzFiyatliUrun.Text = (from x in db.Tbl_Urun
                                        orderby x.SatisFiyat ascending
                                        select x.Ad).FirstOrDefault();

        }
    }
}