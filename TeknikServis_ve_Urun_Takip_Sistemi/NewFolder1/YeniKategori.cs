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
    public partial class YeniKategori : DevExpress.XtraEditors.XtraForm
    {
        public YeniKategori()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void YeniKategori_Load(object sender, EventArgs e)
        {
            //var degerler = db.Tbl_Kategori.ToList();
            //dgv_YeniKategori.DataSource = degerler;

            var degerler = from k in db.Tbl_Kategori
                           select new
                           {
                               k.ID,
                               k.Ad
                           };
            dgv_YeniKategori.DataSource = degerler.ToList();
                        
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if(tx_Kategori.Text=="")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Tbl_Kategori k = new Tbl_Kategori();
            k.ID = byte.Parse(tx_ID.Text);
            k.Ad = tx_Kategori.Text;
            db.Tbl_Kategori.Add(k);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YeniKategori_Load(null, null);


        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if(tx_ID.Text==""||tx_Kategori.Text=="")
            {
                MessageBox.Show("Lütfen Silinecek Satırı Seçiniz..","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            int id = int.Parse(tx_ID.Text);
            var deger = db.Tbl_Kategori.Find(id);
            db.Tbl_Kategori.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YeniKategori_Load(null, null);
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if(tx_ID.Text==""||tx_Kategori.Text=="")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.. Alan Seçtikten Sonra Tekrar Deneyiniz..","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(tx_ID.Text);
            var deger = db.Tbl_Kategori.Find(id);
            deger.ID = byte.Parse(tx_ID.Text);
            deger.Ad = tx_Kategori.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YeniKategori_Load(null, null);

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            YeniKategori_Load(null, null);

        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_ID.Text = "";
            tx_Kategori.Text = "";
        }

        private void dgv_YeniKategori_Click(object sender, EventArgs e)
        {
            if (dgv_YeniKategori.SelectedRows.Count == 0)
                return;
            tx_ID.Text = dgv_YeniKategori.SelectedRows[0].Cells["ID"].Value.ToString();
            tx_Kategori.Text = dgv_YeniKategori.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}