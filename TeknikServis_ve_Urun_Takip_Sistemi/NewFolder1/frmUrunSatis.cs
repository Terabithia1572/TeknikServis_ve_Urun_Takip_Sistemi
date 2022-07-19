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
    public partial class frmUrunSatis : DevExpress.XtraEditors.XtraForm
    {
        public frmUrunSatis()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_Hareket urunKabul = new Tbl_Hareket();
            urunKabul.Urun = int.Parse(tx_UrunAd.Text);
            urunKabul.Musteri = int.Parse(tx_Musteri.Text);
            urunKabul.Personel = short.Parse(tx_Personel.Text);
            urunKabul.Tarih = DateTime.Parse(tx_Tarih.Text);
            urunKabul.Adet = short.Parse(tx_Adet.Text);
            urunKabul.Fiyat = decimal.Parse(tx_SatisFiyat.Text);
            urunKabul.UrunSeriNo = tx_SeriNo.Text;
            db.Tbl_Hareket.Add(urunKabul);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Yapıldı..","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}