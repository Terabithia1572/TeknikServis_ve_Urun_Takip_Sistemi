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
            if(cbx_Okundu.Checked==true)
            {
                int id = int.Parse(tx_ID.Text);
                var degerler = db.Tbl_Notlarim.Find(id);
                //degerler.Baslik = tx_Baslik.Text;
                //degerler.Icerik = tx_Icerik.Text;
                degerler.Durum = true;
                db.SaveChanges();
                MessageBox.Show("Not Durumu Okundu Olarak İşaretlendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNotlar_Load(null, null);
            }
        }

        private void dgv_OkunmayanNotlar_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_OkunmayanNotlar.SelectedRows.Count == 0)
                return;
            tx_ID.Text = dgv_OkunmayanNotlar.SelectedRows[0].Cells["ID"].Value.ToString();
        }
    }
}