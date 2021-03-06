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
            //var degerler2 = db.Tbl_Kategori.ToList();
            cbx_Kategoriler.DataSource = db.Tbl_Kategori.ToList();
            cbx_Kategoriler.ValueMember = "ID";
            cbx_Kategoriler.DisplayMember = "Ad";
           
            //dgv_UrunListesi.OptionsBehavior.Editable = false;    

        }


        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_Urun t = new Tbl_Urun();
            t.Ad = tx_UrunAdi.Text;
            t.Marka = tx_Marka.Text;
            t.AlisFiyat = decimal.Parse(tx_AlisFiyat.Text);
            t.SatisFiyat = decimal.Parse(tx_SatisFiyat.Text);
            t.Stok = short.Parse(tx_Stok.Text);
            t.Durum = false;
            t.Kategori = byte.Parse(cbx_Kategoriler.SelectedValue.ToString());
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
            var degerler = db.Tbl_Urun.ToList();
            dgv_UrunListesi.DataSource = degerler;


        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            var degerler = db.Tbl_Urun.ToList();
            dgv_UrunListesi.DataSource = degerler;
            cbx_Kategoriler.DataSource = db.Tbl_Kategori.ToList();
            cbx_Kategoriler.ValueMember = "ID";
            cbx_Kategoriler.DisplayMember = "Ad";
            MessageBox.Show("Liste Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgv_UrunListesi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_UrunListesi.SelectedRows.Count == 0)
                return;
            tx_UrunAdi.Text = dgv_UrunListesi.SelectedRows[0].Cells["Ad"].Value.ToString();
            tx_Marka.Text = dgv_UrunListesi.SelectedRows[0].Cells["Marka"].Value.ToString();
            tx_AlisFiyat.Text = dgv_UrunListesi.SelectedRows[0].Cells["AlisFiyat"].Value.ToString();
            tx_SatisFiyat.Text = dgv_UrunListesi.SelectedRows[0].Cells["SatisFiyat"].Value.ToString();
            tx_Stok.Text = dgv_UrunListesi.SelectedRows[0].Cells["Stok"].Value.ToString();
            tx_ID.Text = dgv_UrunListesi.SelectedRows[0].Cells["ID"].Value.ToString();
            cbx_Kategoriler.Text = dgv_UrunListesi.SelectedRows[0].Cells["Kategori"].Value.ToString();

        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_UrunAdi.Text = "";
            tx_Marka.Text = "";
            tx_SatisFiyat.Text = "";
            tx_AlisFiyat.Text = "";
            tx_SatisFiyat.Text = "";
            tx_Stok.Text = "";
            tx_ID.Text = "";
            cbx_Kategoriler.SelectedIndex = -1;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tx_ID.Text);
            var deger = db.Tbl_Urun.Find(id);
            db.Tbl_Urun.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            FrmUrunListesi_Load(null, null);
        }

        private void dgv_UrunListesi_Click(object sender, EventArgs e)
        {
            if (dgv_UrunListesi.SelectedRows.Count == 0)
                return;
            tx_UrunAdi.Text = dgv_UrunListesi.SelectedRows[0].Cells["Ad"].Value.ToString();
            tx_Marka.Text = dgv_UrunListesi.SelectedRows[0].Cells["Marka"].Value.ToString();
            tx_AlisFiyat.Text = dgv_UrunListesi.SelectedRows[0].Cells["AlisFiyat"].Value.ToString();
            tx_SatisFiyat.Text = dgv_UrunListesi.SelectedRows[0].Cells["SatisFiyat"].Value.ToString();
            tx_Stok.Text = dgv_UrunListesi.SelectedRows[0].Cells["Stok"].Value.ToString();
            tx_ID.Text = dgv_UrunListesi.SelectedRows[0].Cells["ID"].Value.ToString();
            cbx_Kategoriler.Text = dgv_UrunListesi.SelectedRows[0].Cells["Kategori"].Value.ToString();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tx_ID.Text);
            var deger = db.Tbl_Urun.Find(id);
            deger.Ad = tx_UrunAdi.Text;
            deger.Marka = tx_Marka.Text;
            deger.AlisFiyat = decimal.Parse(tx_AlisFiyat.Text);
            deger.SatisFiyat = decimal.Parse(tx_SatisFiyat.Text);
            deger.Stok = short.Parse(tx_Stok.Text);
            deger.Kategori = byte.Parse(cbx_Kategoriler.SelectedValue.ToString());
            deger.Durum = false;
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            FrmUrunListesi_Load(null, null);
        }
    }
}