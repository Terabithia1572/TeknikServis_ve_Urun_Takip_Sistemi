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
    public partial class frmNotlar : DevExpress.XtraEditors.XtraForm
    {
        public frmNotlar()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void frmNotlar_Load(object sender, EventArgs e)
        {
            dgv_OkunmayanNotlar.DataSource = db.Tbl_Notlarim.Where(x => x.Durum == false).ToList();
            dgv_OkunanNotlar.DataSource = db.Tbl_Notlarim.Where(x => x.Durum == true).ToList();
        }
        public bool isChecked(CheckBox checkbox)
        {
            if (checkbox.CheckState == CheckState.Checked) return true;
            else return false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_Notlarim notlarim = new Tbl_Notlarim();
            notlarim.Baslik = tx_Baslik.Text;
            notlarim.Icerik = tx_Icerik.Text;
            notlarim.Durum = false;
            db.Tbl_Notlarim.Add(notlarim);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmNotlar_Load(null, null);
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            
                int id = int.Parse(tx_ID.Text);
                var degerler = db.Tbl_Notlarim.Find(id);
                degerler.Baslik = tx_Baslik.Text;
                degerler.Icerik = tx_Icerik.Text;
                degerler.Durum = true;
                db.SaveChanges();
                MessageBox.Show("Not Başarıyla Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNotlar_Load(null, null);
            
           
        }

        private void dgv_OkunmayanNotlar_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_OkunmayanNotlar.SelectedRows.Count == 0)
                return;
            tx_ID.Text = dgv_OkunmayanNotlar.SelectedRows[0].Cells["ID"].Value.ToString();
        }

        private void cbx_Okundu_CheckStateChanged(object sender, EventArgs e)
        {
            if (isChecked(cbx_Okundu))
            {
                if (tx_ID.Text == "")
                {
                    MessageBox.Show("Lütfen Okundu Olarak İşaretlenecek Mesajı Seçiniz...", "Bilgi", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    cbx_Okundu.Checked = false;
                    return;
                }
                int id = int.Parse(tx_ID.Text);
                var degerler = db.Tbl_Notlarim.Find(id);
                //degerler.Baslik = tx_Baslik.Text;
                //degerler.Icerik = tx_Icerik.Text;
                degerler.Durum = true;
                db.SaveChanges();
                MessageBox.Show("Not Durumu Okundu Olarak İşaretlendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNotlar_Load(null, null);
                tx_Baslik.Text = "";
                tx_Icerik.Text = "";
                tx_ID.Text = "";
                cbx_Okundu.Checked = false;
            }
            else
            {
                return;
            }
        }

        private void dgv_OkunanNotlar_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_OkunanNotlar.SelectedRows.Count == 0)
                return;
            tx_ID.Text = dgv_OkunanNotlar.SelectedRows[0].Cells["ID"].Value.ToString();
            tx_Baslik.Text = dgv_OkunanNotlar.SelectedRows[0].Cells["Baslik"].Value.ToString();
            tx_Icerik.Text = dgv_OkunanNotlar.SelectedRows[0].Cells["Icerik"].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tx_ID.Text);
            var degerler = db.Tbl_Notlarim.Find(id);
            db.Tbl_Notlarim.Remove(degerler);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmNotlar_Load(null, null);
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            frmNotlar_Load(null, null);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_Baslik.Text = "";
            tx_Icerik.Text = "";
            tx_ID.Text = "";
        }
    }
}