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
    public partial class frmFaturaKalem : DevExpress.XtraEditors.XtraForm
    {
        public frmFaturaKalem()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void frmFaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.Tbl_FaturaDetay
                            select new
                            {
                                x.FaturaDetayID,
                                x.Urun,
                                x.Adet,
                                x.Fiyat,
                                x.Tutar,
                                x.FaturaAd
                            });
            dgv_FaturaDetay.DataSource = degerler.ToList();
            cbx_Fatura.DataSource = (from x in db.Tbl_FaturaBilgi
                                     select new
                                     {
                                         x.ID
                                     }).ToList();
            cbx_Fatura.ValueMember = "ID";
            cbx_Fatura.DisplayMember = "ID";
           
            
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_FaturaDetay faturaDetay = new Tbl_FaturaDetay();
            faturaDetay.Urun = tx_Urun.Text;
            faturaDetay.Adet = short.Parse(tx_Adet.Text);
            faturaDetay.Fiyat = decimal.Parse(tx_Fiyat.Text);
            faturaDetay.Tutar = decimal.Parse(tx_Tutar.Text);
            faturaDetay.FaturaAd = int.Parse(cbx_Fatura.SelectedValue.ToString());
            db.Tbl_FaturaDetay.Add(faturaDetay);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalem Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmFaturaKalem_Load(null, null);
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tx_ID.Text);
            var degerler = db.Tbl_FaturaDetay.Find(id);
            db.Tbl_FaturaDetay.Remove(degerler);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalem Başarıyla Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmFaturaKalem_Load(null, null);
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Tbl_FaturaDetay faturaDetay = new Tbl_FaturaDetay();
            faturaDetay.Urun = tx_Urun.Text;
            faturaDetay.Urun = tx_Urun.Text;
            faturaDetay.Adet = short.Parse(tx_Adet.Text);
            faturaDetay.Fiyat = decimal.Parse(tx_Fiyat.Text);
            faturaDetay.Tutar = decimal.Parse(tx_Tutar.Text);
            faturaDetay.FaturaAd = int.Parse(cbx_Fatura.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Fatura Kalem Başarıyla Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmFaturaKalem_Load(null, null);
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            frmFaturaKalem_Load(null, null);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_ID.Text = "";
            tx_Urun.Text = "";
            tx_Adet.Text = "";
            tx_Fiyat.Text = "";
            tx_Tutar.Text = "";
            cbx_Fatura.SelectedIndex = -1;
        }

        private void dgv_FaturaDetay_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_FaturaDetay.SelectedRows.Count == 0)
                return;
            tx_ID.Text = dgv_FaturaDetay.SelectedRows[0].Cells["FaturaDetayID"].Value.ToString();
           tx_Adet.Text = dgv_FaturaDetay.SelectedRows[0].Cells["Adet"].Value.ToString();
           tx_Fiyat.Text = dgv_FaturaDetay.SelectedRows[0].Cells["Fiyat"].Value.ToString();
            tx_Tutar.Text = dgv_FaturaDetay.SelectedRows[0].Cells["Tutar"].Value.ToString();
            tx_Urun.Text = dgv_FaturaDetay.SelectedRows[0].Cells["Urun"].Value.ToString();
            cbx_Fatura.Text = dgv_FaturaDetay.SelectedRows[0].Cells["FaturaAd"].Value.ToString();
        }

        private void tx_Adet_TextChanged(object sender, EventArgs e)
        {

            if (tx_Adet.Text.Length > 0 && tx_Fiyat.Text.Length > 0)
            {
                decimal sayi1 = Convert.ToDecimal(tx_Adet.Text);
                decimal sayi2 = Convert.ToDecimal(tx_Fiyat.Text);
                decimal sayi3 = sayi1 * sayi2;
                tx_Tutar.Text = sayi3.ToString();

                tx_Tutar.Enabled = false;
            }
        }

        private void tx_Fiyat_TextChanged(object sender, EventArgs e)
        {

            if (tx_Adet.Text.Length > 0 && tx_Fiyat.Text.Length > 0)
            {
                decimal sayi1 = Convert.ToDecimal(tx_Adet.Text);
                decimal sayi2 = Convert.ToDecimal(tx_Fiyat.Text);
                decimal sayi3 = sayi1 * sayi2;
                tx_Tutar.Text = sayi3.ToString();

                tx_Tutar.Enabled = false;
            }
        }
    }
}