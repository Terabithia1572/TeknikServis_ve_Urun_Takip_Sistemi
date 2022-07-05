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
    public partial class FrmUrunListesi : DevExpress.XtraEditors.XtraForm
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            //Listeleme ToList Add Remove 

            var degerler = db.Tbl_Urun.ToList();
            dgv_UrunListesi.DataSource = degerler;
            //dgv_UrunListesi.OptionsBehavior.Editable = false;    

        }


        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_Urun t = new Tbl_Urun();
            t.Ad = tx_UrunAdi.Text;
            t.Marka = tx_Marka.Text;
            t.AlisFiyat = decimal.Parse(tx_AlisFiyat.Text);
            t.SatisFiyat = decimal.Parse(tx_SatisFiyat.Text);
            t.Stok = short.Parse(tx_Stok.Text);
            t.Durum = false;
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
            var degerler = db.Tbl_Urun.ToList();
            dgv_UrunListesi.DataSource = degerler;


        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            var degerler = db.Tbl_Urun.ToList();
            dgv_UrunListesi.DataSource = degerler;
            MessageBox.Show("Liste Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgv_UrunListesi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          //  tx_UrunAdi.Text = dgv_UrunListesi.RowHeaderCellChanged("").ToString();
        }
    }
}