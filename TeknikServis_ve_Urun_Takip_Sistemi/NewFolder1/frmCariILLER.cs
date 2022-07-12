using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis_ve_Urun_Takip_Sistemi.NewFolder1
{
    public partial class frmCariILLER : DevExpress.XtraEditors.XtraForm
    {
        public frmCariILLER()
        {
            InitializeComponent();
        }

        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Db_TeknikServis;Integrated Security=True");
        private void frmCariILLER_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("Van", 10);
            //chartControl1.Series["Series 1"].Points.AddPoint("Hakkari", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Şırnak", 6);
            //chartControl1.Series["Series 1"].Points.AddPoint("Adıyaman", 5);
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 3);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 7);
            dgv_CariListesi.DataSource = db.Tbl_Cari.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new
            {
                İL = z.Key,
                Toplam = z.Count()
            }).ToList();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IL,Count(*) as 'Toplam İL Sayısı' from Tbl_Cari group by IL", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
              
            }  
            baglanti.Close();
        }
    }
}