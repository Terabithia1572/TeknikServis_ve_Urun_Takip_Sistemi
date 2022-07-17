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
    public partial class frmFaturaListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmFaturaListesi()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void frmFaturaListesi_Load(object sender, EventArgs e)
        {
            String hourMinute = DateTime.Now.ToString("HH:mm");
            String date = DateTime.Now.ToString("dd/MM/yyyy");
            tx_Saat.Text = hourMinute;
            tx_Tarih.Text = date;

            var degerler = (from x in db.Tbl_FaturaBilgi
                            select new
                            {
                                x.ID,
                                x.Seri,
                                x.SeriNo,
                                x.Tarih,
                                x.Saat,
                                x.VergiDaire,
                                x.Alici,
                                CariAd = x.Tbl_Cari.Ad+" "+x.Tbl_Cari.Soyad,
                                Personel = x.Tbl_Personel.Ad+" "+x.Tbl_Personel.Soyad
                            });
            dgv_FaturaListesi.DataSource = degerler.ToList();
            cbx_Cari.DataSource = (from x in db.Tbl_Cari
                                   select new
                                   {
                                       x.ID,
                                      CariAdSoyad= x.Ad+" "+x.Soyad
                                   }).ToList();
            cbx_Cari.ValueMember = "ID";
            cbx_Cari.DisplayMember = "CariAdSoyad";

            cbx_Personel.DataSource = (from x in db.Tbl_Personel
                                       select new
                                       {
                                           x.ID,
                                           PersonelAdSoyad=x.Ad+" "+x.Soyad
                                       }).ToList();
            cbx_Personel.ValueMember = "ID";
            cbx_Personel.DisplayMember = "PersonelAdSoyad";


        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Tbl_FaturaBilgi faturaBilgi = new Tbl_FaturaBilgi();
                faturaBilgi.Seri = tx_Seri.Text;
                faturaBilgi.SeriNo = tx_SeriNo.Text;
                faturaBilgi.Tarih = DateTime.Parse(tx_Tarih.Text);
                faturaBilgi.Saat = tx_Saat.Text;
                faturaBilgi.VergiDaire = tx_VergiDairesi.Text;
                faturaBilgi.Alici = tx_Alici.Text;
                faturaBilgi.Cari = int.Parse(cbx_Cari.SelectedValue.ToString());
                faturaBilgi.Personel = short.Parse(cbx_Personel.SelectedValue.ToString());
                db.Tbl_FaturaBilgi.Add(faturaBilgi);
                db.SaveChanges();
                MessageBox.Show("Fatura Bilgisi Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmFaturaListesi_Load(null, null);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata..");
                return;
            }         
            //Tbl_FaturaBilgi faturaBilgi = new Tbl_FaturaBilgi();
            //faturaBilgi.Seri = tx_Seri.Text;
            //faturaBilgi.SeriNo = tx_SeriNo.Text;
            //faturaBilgi.Tarih = DateTime.Parse(tx_Tarih.Text);
            //faturaBilgi.Saat = tx_Saat.Text;
            //faturaBilgi.VergiDaire = tx_VergiDairesi.Text;
            //faturaBilgi.Alici = tx_Alici.Text;
            //faturaBilgi.Cari = int.Parse(cbx_Cari.Text);
            //faturaBilgi.Personel = short.Parse(cbx_Personel.Text);
            //db.Tbl_FaturaBilgi.Add(faturaBilgi);
            //db.SaveChanges();
            //MessageBox.Show("Fatura Bilgisi Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //frmFaturaListesi_Load(null, null);
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tx_ID.Text);
            var degerler = db.Tbl_FaturaBilgi.Find(id);
            db.Tbl_FaturaBilgi.Remove(degerler);
            db.SaveChanges();
            MessageBox.Show("Fatura Bilgisi Başarıyla Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            frmFaturaListesi_Load(null, null);
        }

        private void dgv_FaturaListesi_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_FaturaListesi.SelectedRows.Count == 0)
                return;
            tx_ID.Text = dgv_FaturaListesi.SelectedRows[0].Cells["ID"].Value.ToString();
            tx_Seri.Text = dgv_FaturaListesi.SelectedRows[0].Cells["Seri"].Value.ToString();
            tx_SeriNo.Text = dgv_FaturaListesi.SelectedRows[0].Cells["SeriNo"].Value.ToString();
            tx_Tarih.Text = dgv_FaturaListesi.SelectedRows[0].Cells["Tarih"].Value.ToString();
            tx_Saat.Text = dgv_FaturaListesi.SelectedRows[0].Cells["Saat"].Value.ToString();
            tx_VergiDairesi.Text = dgv_FaturaListesi.SelectedRows[0].Cells["VergiDaire"].Value.ToString();
            tx_Alici.Text = dgv_FaturaListesi.SelectedRows[0].Cells["Alici"].Value.ToString();
            cbx_Cari.Text = dgv_FaturaListesi.SelectedRows[0].Cells["CariAd"].Value.ToString();
            cbx_Personel.Text = dgv_FaturaListesi.SelectedRows[0].Cells["Personel"].Value.ToString();
            
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Tbl_FaturaBilgi faturaBilgi = new Tbl_FaturaBilgi();
            faturaBilgi.Seri = tx_Seri.Text;
            faturaBilgi.SeriNo = tx_SeriNo.Text;
            faturaBilgi.Tarih = DateTime.Parse(tx_Tarih.Text);
            faturaBilgi.Saat = tx_Saat.Text;
            faturaBilgi.VergiDaire = tx_VergiDairesi.Text;
            faturaBilgi.Alici = tx_Alici.Text;
            faturaBilgi.Cari = int.Parse(cbx_Cari.SelectedValue.ToString());
            faturaBilgi.Personel = short.Parse(cbx_Personel.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Fatura Bilgisi Başarıyla Güncellendi..","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            frmFaturaListesi_Load(null, null);

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            frmFaturaListesi_Load(null, null);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_Alici.Text = "";
            tx_ID.Text = "";
            tx_Saat.Text = "";
            tx_Seri.Text = "";
            tx_SeriNo.Text = "";
            tx_Tarih.Text = "";
            tx_VergiDairesi.Text = "";
            cbx_Cari.SelectedIndex = -1;
            cbx_Personel.SelectedIndex = -1;
        }
    }
}