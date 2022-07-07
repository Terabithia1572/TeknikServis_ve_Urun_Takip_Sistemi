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
    public partial class frmKategori : DevExpress.XtraEditors.XtraForm
    {
        public frmKategori()
        {
            InitializeComponent();
        }

        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void frmKategori_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.Tbl_Kategori
                           select new
                           {
                               k.ID,
                               k.Ad
                           };

            dgv_KategoriListesi.DataSource = degerler.ToList();
        }

        private void dgv_KategoriListesi_MouseClick(object sender, MouseEventArgs e)
        {

            if (dgv_KategoriListesi.SelectedRows.Count == 0)
                return;
            tx_ID.Text = dgv_KategoriListesi.SelectedRows[0].Cells["ID"].Value.ToString();
            tx_Kategori.Text = dgv_KategoriListesi.SelectedRows[0].Cells["Ad"].Value.ToString();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (tx_ID.Text == "" || tx_Kategori.Text == "")
            {
                MessageBox.Show("Lütfen Kategori Adını Boş Bırakmayınız..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                // tx_ID.Text = "";
                Tbl_Kategori k = new Tbl_Kategori();
                // k.ID = byte.Parse(tx_ID.Text);
                k.Ad = tx_Kategori.Text;
                db.Tbl_Kategori.Add(k);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmKategori_Load(null, null);
            }

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (tx_ID.Text == "")
            {
                MessageBox.Show("Lütfen Bir Sutün veya ID Seçin..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int id = int.Parse(tx_ID.Text);
                var deger = db.Tbl_Kategori.Find(id);
                db.Tbl_Kategori.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmKategori_Load(null, null);
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (tx_ID.Text == "" || tx_ID.Text == "")
            {
                MessageBox.Show("Lütfen Güncellenecek Kategoriyi Seçiniz..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                int id = int.Parse(tx_ID.Text);
                var deger = db.Tbl_Kategori.Find(id);
                deger.ID = byte.Parse(tx_ID.Text);
                deger.Ad = tx_Kategori.Text;
                db.SaveChanges();
                MessageBox.Show("Kategori Başaryla Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                frmKategori_Load(null, null);
            }

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            frmKategori_Load(null, null);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_ID.Text = "";
            tx_Kategori.Text = "";
        }
    }
}