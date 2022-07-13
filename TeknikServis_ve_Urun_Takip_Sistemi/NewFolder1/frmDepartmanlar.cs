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
    public partial class frmDepartmanlar : DevExpress.XtraEditors.XtraForm
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }

        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.Tbl_Departman
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Aciklama
                            }).ToList();
            dgv_Departmanlar.DataSource = degerler;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_Departman departman = new Tbl_Departman();
            departman.Ad = tx_Ad.Text;
            departman.Aciklama = tx_Aciklama.Text;
            db.Tbl_Departman.Add(departman);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmDepartmanlar_Load(null, null);
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tx_ID.Text);
            var degerler = db.Tbl_Departman.Find(id);
            db.Tbl_Departman.Remove(degerler);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            frmDepartmanlar_Load(null, null);
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tx_ID.Text);
            var degerler = db.Tbl_Departman.Find(id);
            degerler.Ad = tx_Ad.Text;
            degerler.Aciklama = tx_Aciklama.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmDepartmanlar_Load(null, null);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_Aciklama.Text = "";
            tx_Ad.Text = "";
            tx_ID.Text = "";
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            frmDepartmanlar_Load(null, null);
        }

        private void dgv_Departmanlar_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_Departmanlar.SelectedRows.Count == 0)
                return;
            tx_Ad.Text = dgv_Departmanlar.SelectedRows[0].Cells["Ad"].Value.ToString();
            tx_Aciklama.Text = dgv_Departmanlar.SelectedRows[0].Cells["Aciklama"].Value.ToString();
            tx_ID.Text = dgv_Departmanlar.SelectedRows[0].Cells["ID"].Value.ToString();
        }
    }
}