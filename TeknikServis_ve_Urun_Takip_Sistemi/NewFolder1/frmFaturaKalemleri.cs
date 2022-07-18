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
    public partial class frmFaturaKalemleri : DevExpress.XtraEditors.XtraForm
    {
        public frmFaturaKalemleri()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void btn_Ara_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tx_FaturaID.Text);
            var degerler = (from x in db.Tbl_FaturaDetay
                            select new
                            {
                                x.FaturaDetayID,
                                x.Urun,
                                x.Adet,
                                x.Fiyat,
                                x.Tutar,
                                x.FaturaAd
                            }).Where(x=>x.FaturaDetayID==id).ToList();
            dgv_FaturaKalemleri.DataSource = degerler;
        }
    }
}