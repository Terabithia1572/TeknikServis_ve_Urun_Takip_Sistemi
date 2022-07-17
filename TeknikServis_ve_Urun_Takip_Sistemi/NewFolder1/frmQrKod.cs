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

        private void btn_QRKodEkle_Click(object sender, EventArgs e)
        {
            QRCodeEncoder qRCodeEncoder = new QRCodeEncoder();
            pictureEdit1.Image = qRCodeEncoder.Encode(textEdit1.Text);
        }
    }
}