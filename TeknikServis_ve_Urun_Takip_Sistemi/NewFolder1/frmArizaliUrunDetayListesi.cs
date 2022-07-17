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
    public partial class frmArizaliUrunDetayListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmArizaliUrunDetayListesi()
        {
            InitializeComponent();
        }

        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void frmArizaliUrunDetayListesi_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.Tbl_UrunTakip
                            select new
                            {
                                x.TakipID,
                                x.Aciklama,
                                x.Tarih,
                                x.SeriNo,

                            });
            dgv_ArizaliUrunDetayListesi.DataSource = degerler.ToList();
        }
    }
}