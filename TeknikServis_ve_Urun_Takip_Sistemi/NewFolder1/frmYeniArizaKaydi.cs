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
    public partial class frmYeniArizaKaydi : DevExpress.XtraEditors.XtraForm
    {
        public frmYeniArizaKaydi()
        {
            InitializeComponent();
        }

        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void frmYeniArizaKaydi_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_UrunKabul urunKabul = new Tbl_UrunKabul();
            urunKabul.Cari = int.Parse(tx_MusteriID.Text);
            urunKabul.Personel = short.Parse(tx_Personel.Text);
            urunKabul.GelisTarih = DateTime.Parse(tx_Tarih.Text);
            urunKabul.UrunSeriNo = tx_SeriNo.Text;
            db.Tbl_UrunKabul.Add(urunKabul);
            db.SaveChanges();
            MessageBox.Show("Arıza Kaydı Başarıyla Yapıldı..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


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