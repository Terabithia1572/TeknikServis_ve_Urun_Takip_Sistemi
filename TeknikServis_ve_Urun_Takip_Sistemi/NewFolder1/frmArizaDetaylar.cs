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
    public partial class frmArizaDetaylar : DevExpress.XtraEditors.XtraForm
    {
        public frmArizaDetaylar()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Tbl_UrunTakip urunTakip = new Tbl_UrunTakip();
            urunTakip.Aciklama = tx_Aciklama.Text;
            urunTakip.SeriNo = tx_SeriNo.Text;
            urunTakip.Tarih = DateTime.Parse(tx_Tarih.Text);
            db.Tbl_UrunTakip.Add(urunTakip);
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Detayları Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmArizaDetaylar_Load(object sender, EventArgs e)
        {
            btn_Kapat.TabStop = false;
            btn_Kapat.FlatStyle = FlatStyle.Flat;
            btn_Kapat.FlatAppearance.BorderSize = 0;
            btn_Kapat.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
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