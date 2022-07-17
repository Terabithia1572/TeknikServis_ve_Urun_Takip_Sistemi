using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis_ve_Urun_Takip_Sistemi
{
    public partial class XtraForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public XtraForm1()
        {
            InitializeComponent();

            BindingList<Customer> dataSource = GetDataSource();
            //gridControl.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
           // gridControl.ShowRibbonPrintPreview();
        }
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            result.Add(new Customer()
            {
                ID = 1,
                Name = "ACME",
                Address = "2525 E El Segundo Blvd",
                City = "El Segundo",
                State = "CA",
                ZipCode = "90245",
                Phone = "(310) 536-0611"
            });
            result.Add(new Customer()
            {
                ID = 2,
                Name = "Electronics Depot",
                Address = "2455 Paces Ferry Road NW",
                City = "Atlanta",
                State = "GA",
                ZipCode = "30339",
                Phone = "(800) 595-3232"
            });
            return result;
        }
        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }
            public string Phone { get; set; }
        }


        private void XtraForm1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_UrunlerListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.FrmUrunListesi fr = new NewFolder1.FrmUrunListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.YeniUrunEkleme yu = new NewFolder1.YeniUrunEkleme();
            yu.MdiParent = this;
            yu.Show();
        }

        private void btn_Kategoriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmKategori fk = new NewFolder1.frmKategori();
            fk.MdiParent=this;
            fk.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.YeniKategori yk = new NewFolder1.YeniKategori();
            yk.MdiParent = this;
            yk.Show();
        }

        private void btn_UrunIstatistik_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.UrunIstatistik ui = new NewFolder1.UrunIstatistik();
            ui.MdiParent = this;
            ui.Show();
        }

        private void btn_MarkaIstatistik_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.XtraForm3 fm = new NewFolder1.XtraForm3();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmCariListesi fc = new NewFolder1.frmCariListesi();
            fc.MdiParent = this;
            fc.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmCariILLER CI = new NewFolder1.frmCariILLER();
            CI.MdiParent = this;
            CI.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmCariListesi CL = new NewFolder1.frmCariListesi();
            CL.MdiParent = this;
            CL.Show();
        }

        private void btn_DepartmanListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmDepartmanlar fd = new NewFolder1.frmDepartmanlar();
            fd.MdiParent = this;
            fd.Show();
        }

        private void btn_YeniDepartman_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmYeniDepartman ydp = new NewFolder1.frmYeniDepartman();
            ydp.MdiParent = this;
            ydp.Show();
        }

        private void btn_PersonelListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmPersoneller fp = new NewFolder1.frmPersoneller();
                fp.MdiParent = this;
            fp.Show();
        }

        private void btn_HesapMakinesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btn_DovizKurlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmKurlar frmKurlar = new NewFolder1.frmKurlar();
            frmKurlar.MdiParent = this;
            frmKurlar.Show();
        }

        private void btn_Word_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmYoutube fy = new NewFolder1.frmYoutube();
            fy.MdiParent = this;
            fy.Show();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmNotlar fn = new NewFolder1.frmNotlar();
            fn.MdiParent = this;
            fn.Show();
        }

        private void btn_ArizaliUrun_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmArizaListesi al = new NewFolder1.frmArizaListesi();
            al.MdiParent = this;
            al.Show();
        }

        private void btn_YeniUrunSatis_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmUrunSatis us = new NewFolder1.frmUrunSatis();
               // us.MdiParent = this;
            us.Show();
        }

        private void btn_SatisListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmSatislar s = new NewFolder1.frmSatislar();
            s.MdiParent = this;
            s.Show();
        }

        private void btn_ArizaliUrunKaydi_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmYeniArizaKaydi ya = new NewFolder1.frmYeniArizaKaydi();
           // ya.MdiParent = this;
            ya.Show();
        }

        private void btn_ArizaUrunAciklama_ItemClick(object sender, ItemClickEventArgs e)
        {
            NewFolder1.frmArizaDetaylar ad = new NewFolder1.frmArizaDetaylar();
            ad.Show();
        }
    }
}