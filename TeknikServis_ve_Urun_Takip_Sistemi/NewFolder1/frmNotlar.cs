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
    public partial class frmNotlar : DevExpress.XtraEditors.XtraForm
    {
        public frmNotlar()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void frmNotlar_Load(object sender, EventArgs e)
        {
            dgv_OkunmayanNotlar.DataSource = db.Tbl_Notlarim.Where(x => x.Durum == false).ToList();
            dgv_OkunanNotlar.DataSource = db.Tbl_Notlarim.Where(x => x.Durum == true).ToList();
        }
    }
}