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
    public partial class UrunIstatistik : DevExpress.XtraEditors.XtraForm
    {
        public UrunIstatistik()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();

        private void UrunIstatistik_Load(object sender, EventArgs e)
        {
            lbl_ToplamUrunSayisi.Text = db.Tbl_Urun.Count().ToString();
            lbl_ToplamKategoriSayisi.Text = db.Tbl_Kategori.Count().ToString();
            lbl_ToplamStokSayisi.Text = db.Tbl_Urun.Sum(x => x.Stok).ToString();
            lbl_EnFazlaStokluUrun.Text = (from i in db.Tbl_Urun
                                             orderby i.Stok descending
                                             select i.Ad).FirstOrDefault();

        }
    }
}