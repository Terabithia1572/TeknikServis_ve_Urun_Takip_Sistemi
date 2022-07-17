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
    }
}