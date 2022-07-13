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
    public partial class frmYeniDepartman : DevExpress.XtraEditors.XtraForm
    {
        public frmYeniDepartman()
        {
            InitializeComponent();
        }
        NewFolder1.frmDepartmanlar fdd = new NewFolder1.frmDepartmanlar();
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Tbl_Departman departman = new Tbl_Departman();
            departman.Ad = tx_YeniDepartman.Text;
            departman.Aciklama = tx_Aciklama.Text;
            db.Tbl_Departman.Add(departman);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Eklendi Departman Listesi Açılıyor..", "Bilgi",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            fdd.DepartmanListesiYukle();
            fdd.Show();
        }
    }
}