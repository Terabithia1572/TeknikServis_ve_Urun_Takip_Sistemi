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
    public partial class frmPersoneller : DevExpress.XtraEditors.XtraForm
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }

        Db_TeknikServisEntities db = new Db_TeknikServisEntities();
        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            //Card 1 
            metroLabel8.Parent = pictureBox1;
            metroLabel8.BackColor = Color.Transparent;
            metroLabel9.Parent = pictureBox1;
            metroLabel9.BackColor = Color.Transparent;
            metroLabel10.Parent = pictureBox1;
            metroLabel10.BackColor = Color.Transparent;
            metroLabel11.Parent = pictureBox1;
            metroLabel11.BackColor = Color.Transparent;
           metroLabel12.Parent = pictureBox1;
            metroLabel12.BackColor = Color.Transparent;
            metroLabel13.Parent = pictureBox1;
            metroLabel13.BackColor = Color.Transparent;
              //metroLabel11.Location = new Point(23,232);
            //Card 2
            //metroLabel14.Parent = pictureBox2;
            //metroLabel14.BackColor = Color.Transparent;
            //metroLabel15.Parent = pictureBox2;
            //metroLabel15.BackColor = Color.Transparent;
            //metroLabel16.Parent = pictureBox2;
            //metroLabel16.BackColor = Color.Transparent;
            //metroLabel17.Parent = pictureBox2;
            //metroLabel17.BackColor = Color.Transparent;
            //metroLabel18.Parent = pictureBox2;
            //metroLabel18.BackColor = Color.Transparent;
         //   metroLabel19.Location=new Point(209,166);
            //metroLabel19.Parent = pictureBox4;
            metroLabel19.BackColor = Color.Transparent;
           // metroLabel19.Parent = pictureBox2;
         //   metroLabel19.ForeColor = Color.White;

         //   lbl_AdSoyad.Parent=pictureBox2;


            var listele = (from x in db.Tbl_Personel
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.Fotograf,
                               x.Mail,
                               x.Telefon,
                               x.Departman
                               
                           }).ToList();
            dgv_Personel.DataSource = listele;

            cbx_Departman.DataSource = (from x in db.Tbl_Departman
                                        select new
                                        {
                                            x.ID,
                                            x.Ad
                                        }).ToList();


            //cbx_Departman.DataSource = db.Tbl_Departman.ToList();
            cbx_Departman.ValueMember = "ID";
            cbx_Departman.DisplayMember = "Ad";

            string ad1,soyad1,mail1,departman1;
            ad1 = db.Tbl_Personel.First(x => x.ID == 1).Ad;
            soyad1 = db.Tbl_Personel.First(x => x.ID == 1).Soyad;
            metroLabel9.Text = ad1 + " " + soyad1;
            mail1 = db.Tbl_Personel.First(x => x.ID == 1).Mail;
            metroLabel10.Text = mail1;
            departman1 = db.Tbl_Personel.First(x => x.ID == 1).Tbl_Departman.Ad;
            metroLabel12.Text = departman1;

            // 18 14 16
            string ad2, soyad2, mail2, departman2;
            ad2 = db.Tbl_Personel.First(x => x.ID == 2).Ad;
            soyad2 = db.Tbl_Personel.First(x => x.ID == 2).Soyad;
            metroLabel18.Text = ad2 + " " + soyad2;
            departman2 = db.Tbl_Personel.First(x => x.ID == 2).Tbl_Departman.Ad;
            metroLabel14.Text = departman2;
            mail2 = db.Tbl_Personel.First(x => x.ID == 2).Mail;
            metroLabel16.Text = mail2;


        }


        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_Personel personel = new Tbl_Personel();
            personel.Ad = tx_Ad.Text;
            personel.Soyad = tx_Soyad.Text;
            personel.Fotograf = tx_Fotograf.Text;
            personel.Mail = tx_Mail.Text;
            personel.Telefon = tx_Telefon.Text;
            personel.Departman = byte.Parse(cbx_Departman.SelectedValue.ToString());
            db.Tbl_Personel.Add(personel);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Eklendi..",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPersoneller_Load(null, null);

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tx_ID.Text);
            var degerler = db.Tbl_Personel.Find(id);
            db.Tbl_Personel.Remove(degerler);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            frmPersoneller_Load(null, null);
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Tbl_Personel personel = new Tbl_Personel();
            personel.Ad = tx_Ad.Text;
            personel.Soyad = tx_Soyad.Text;
            personel.Fotograf = tx_Fotograf.Text;
            personel.Mail = tx_Mail.Text;
            personel.Telefon = tx_Telefon.Text;
            personel.Departman = byte.Parse(cbx_Departman.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            frmPersoneller_Load(null, null);
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            frmPersoneller_Load(null,null);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_Ad.Text = tx_Fotograf.Text = tx_ID.Text = tx_Soyad.Text = tx_Telefon.Text = tx_Mail.Text = "";
            cbx_Departman.SelectedIndex = -1;
        }

        private void dgv_Personel_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_Personel.SelectedRows.Count == 0)
                return;
            
            tx_Ad.Text = dgv_Personel.SelectedRows[0].Cells["Ad"].Value.ToString();
            tx_Soyad.Text = dgv_Personel.SelectedRows[0].Cells["SoyAd"].Value.ToString();
            tx_Fotograf.Text = dgv_Personel.SelectedRows[0].Cells["Fotograf"].Value.ToString();
            tx_Mail.Text = dgv_Personel.SelectedRows[0].Cells["Mail"].Value.ToString();
            tx_Telefon.Text = dgv_Personel.SelectedRows[0].Cells["Telefon"].Value.ToString();
            tx_ID.Text = dgv_Personel.SelectedRows[0].Cells["ID"].Value.ToString();
            cbx_Departman.Text = dgv_Personel.SelectedRows[0].Cells["Departman"].Value.ToString();
        }
    }
}