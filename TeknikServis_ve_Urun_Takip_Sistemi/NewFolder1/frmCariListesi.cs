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

    }
}