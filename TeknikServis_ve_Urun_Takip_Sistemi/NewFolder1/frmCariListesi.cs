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
    public partial class frmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmCariListesi()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void frmCariListesi_Load(object sender, EventArgs e)
        {
            var listele = (from x in db.Tbl_Cari
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.Telefon,
                               x.IL,
                               x.ILCE,
                               x.Banka,
                               x.VergiDairesi,
                               x.VergiNo,
                               x.Statu,
                               x.Mail,
                               x.Adres
                           }).ToList();

            dgv_CariListesi.DataSource = listele;
        }

        private void tx_Telefon_TextChanged(object sender, EventArgs e)
        {
            //string x = tx_Telefon.Text;

            //string y = (x).ToString();

            //tx_Telefon.Text = String.Format("{0:###-####-##-##}", y);
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_Cari cari = new Tbl_Cari();
           
            cari.Ad = tx_Ad.Text;
            cari.Soyad = tx_Soyad.Text;
            cari.Telefon = tx_Telefon.Text;
            cari.IL = tx_IL.Text;
            cari.ILCE = tx_ILCE.Text;
            cari.Banka = tx_Banka.Text;
            cari.VergiDairesi = tx_VergiDairesi.Text;
            cari.VergiNo = tx_VergiNo.Text;
            cari.Statu = tx_Statu.Text;
            cari.Mail = tx_Mail.Text;
            cari.Adres = tx_Adres.Text;
            db.Tbl_Cari.Add(cari);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmCariListesi_Load(null, null);
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tx_ID.Text);
            var deger = db.Tbl_Cari.Find(id);
            db.Tbl_Cari.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Silindi..","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            frmCariListesi_Load(null, null);


        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tx_ID.Text);
            var degerler = db.Tbl_Cari.Find(id);
            degerler.Ad = tx_Ad.Text;
            degerler.Soyad = tx_Soyad.Text;
            degerler.Telefon = tx_Telefon.Text;
            degerler.IL = tx_IL.Text;
            degerler.ILCE = tx_ILCE.Text;
            degerler.Banka = tx_Banka.Text;
            degerler.VergiDairesi = tx_VergiDairesi.Text;
            degerler.VergiNo = tx_VergiNo.Text;
            degerler.Statu = tx_Statu.Text;
            degerler.Mail = tx_Mail.Text;
            degerler.Adres = tx_Adres.Text;
            db.SaveChanges();
            MessageBox.Show("Cari Listesi Başarıyla Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            frmCariListesi_Load(null, null);

        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_Ad.Text = "";
            tx_Adres.Text = "";
            tx_Soyad.Text = "";
            tx_Telefon.Text = "";
            tx_IL.Text = "";
            tx_ILCE.Text = "";
            tx_Banka.Text = "";
            tx_VergiDairesi.Text = "";
            tx_VergiNo.Text = "";
            tx_Mail.Text = "";
            tx_Statu.Text = "";
            tx_ID.Text = "";
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            frmCariListesi_Load(null, null);
        }

        private void dgv_CariListesi_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_CariListesi.SelectedRows.Count == 0)
                return;
            try
            {
                tx_ID.Text = dgv_CariListesi.SelectedRows[0].Cells["ID"].Value.ToString();
                tx_Ad.Text = dgv_CariListesi.SelectedRows[0].Cells["Ad"].Value.ToString();
                tx_Soyad.Text = dgv_CariListesi.SelectedRows[0].Cells["Soyad"].Value.ToString();
                tx_Telefon.Text = dgv_CariListesi.SelectedRows[0].Cells["Telefon"].Value.ToString();
                tx_IL.Text = dgv_CariListesi.SelectedRows[0].Cells["IL"].Value.ToString();
                tx_ILCE.Text = dgv_CariListesi.SelectedRows[0].Cells["ILCE"].Value.ToString();
                tx_Banka.Text = dgv_CariListesi.SelectedRows[0].Cells["Banka"].Value.ToString();
                tx_VergiDairesi.Text = dgv_CariListesi.SelectedRows[0].Cells["VergiDairesi"].Value.ToString();
                tx_VergiNo.Text = dgv_CariListesi.SelectedRows[0].Cells["VergiNo"].Value.ToString();
                tx_Statu.Text = dgv_CariListesi.SelectedRows[0].Cells["Statu"].Value.ToString();
                tx_Mail.Text = dgv_CariListesi.SelectedRows[0].Cells["Mail"].Value.ToString();
                tx_Adres.Text = dgv_CariListesi.SelectedRows[0].Cells["Adres"].Value.ToString();
            }
            catch (Exception deneme)
            {

                MessageBox.Show(deneme.ToString());
            }
          
        }
    }
}