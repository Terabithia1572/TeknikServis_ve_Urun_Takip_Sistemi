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
using MessagingToolkit.QRCode.Codec;

namespace TeknikServis_ve_Urun_Takip_Sistemi.NewFolder1
{
    public partial class frmQrKod : DevExpress.XtraEditors.XtraForm
    {
        public frmQrKod()
        {
            InitializeComponent();
        }
        Db_TeknikServisEntities db = new Db_TeknikServisEntities();

        private void btn_QRKodEkle_Click(object sender, EventArgs e)
        {
            QRCodeEncoder qRCodeEncoder = new QRCodeEncoder();
            pictureEdit1.Image = qRCodeEncoder.Encode(cbx_SeriNo.Text);
        }

        private void frmQrKod_Load(object sender, EventArgs e)
        {
            cbx_SeriNo.DataSource = (from x in db.Tbl_UrunKabul
                                     select new
                                     {
                                         x.islemID,
                                         x.UrunSeriNo
                                     }).ToList();
            cbx_SeriNo.ValueMember = "islemID";
            cbx_SeriNo.DisplayMember = "UrunSeriNo";
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}