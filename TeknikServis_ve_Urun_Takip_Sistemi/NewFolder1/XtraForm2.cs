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
    public partial class frmMarkalar : DevExpress.XtraEditors.XtraForm
    {
        public frmMarkalar()
        {
            InitializeComponent();
        }

        Db_TeknikServisEntities db = new Db_TeknikServisEntities();

        private void frmMarkalar_Load(object sender, EventArgs e)
        {
            var listele = db.Tbl_Urun.OrderBy(x => x.Marka).GroupBy(y => y.Marka).
               Select(z => new
               {
                   Marka = z.Key,
                   Toplam = z.Count()
               });
            dgv_MarkaListesi.DataSource = listele.ToList();
            lbl_ToplamMarkaSayisi.Text = db.Tbl_Urun.Count().ToString();
            lbl_EnFazlaStokluUrun.Text = (from x in db.Tbl_Urun
                                          select x.Marka)
                                          .Distinct().Count().ToString();

            chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 24);
            chartControl1.Series["Series 1"].Points.AddPoint("Beko", 6);
            chartControl1.Series["Series 1"].Points.AddPoint("Vestel", 14);

            chartControl2.Series["Kategoriler"].Points.AddPoint("Beyaz Eşya", 4);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Bilgisayar", 24);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Küçük Ev Aletleri", 6);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Süpürge", 14);

        }
    }
}