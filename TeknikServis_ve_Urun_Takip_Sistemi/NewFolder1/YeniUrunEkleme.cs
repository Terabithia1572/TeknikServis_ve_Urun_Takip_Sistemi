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
    public partial class YeniUrunEkleme : DevExpress.XtraEditors.XtraForm
    {
        public YeniUrunEkleme()
        {
            InitializeComponent();
        }

        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_Urun urun = new Tbl_Urun();
            urun.Ad = tx_UrunAdi.Text;
            urun.Marka = tx_Marka.Text;
            urun.AlisFiyat = Convert.ToDecimal(tx_AlisFiyat.Text);
            urun.SatisFiyat = decimal.Parse(tx_SatisFiyat.Text);
            urun.Kategori = byte.Parse(cbx_Kategoriler.SelectedValue.ToString());
            urun.Stok = short.Parse(tx_Stok.Text);
            urun.Durum = false;
            
            db.Tbl_Urun.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Eklendi..","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Vazgeç_Click(object sender, EventArgs e)
        {
            FrmUrunListesi fl = new FrmUrunListesi();
            fl.Show();
        }

        private void YeniUrunEkleme_Load(object sender, EventArgs e)
        {
            cbx_Kategoriler.DataSource = db.Tbl_Kategori.ToList();
            cbx_Kategoriler.ValueMember = "ID";
            cbx_Kategoriler.DisplayMember = "Ad";
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