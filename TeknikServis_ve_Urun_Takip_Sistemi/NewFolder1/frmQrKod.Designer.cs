
namespace TeknikServis_ve_Urun_Takip_Sistemi.NewFolder1
{
    partial class frmQrKod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbx_SeriNo = new MetroFramework.Controls.MetroComboBox();
            this.btn_QRKodEkle = new Guna.UI2.WinForms.Guna2Button();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btn_Hide = new MetroFramework.Controls.MetroButton();
            this.btn_Kapat = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(76, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(186, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Seri No İçin QR Kod Oluşturun";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(76, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Seri No:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // cbx_SeriNo
            // 
            this.cbx_SeriNo.FormattingEnabled = true;
            this.cbx_SeriNo.ItemHeight = 23;
            this.cbx_SeriNo.Location = new System.Drawing.Point(139, 65);
            this.cbx_SeriNo.Name = "cbx_SeriNo";
            this.cbx_SeriNo.Size = new System.Drawing.Size(121, 29);
            this.cbx_SeriNo.TabIndex = 45;
            this.cbx_SeriNo.UseSelectable = true;
            // 
            // btn_QRKodEkle
            // 
            this.btn_QRKodEkle.BackColor = System.Drawing.Color.Transparent;
            this.btn_QRKodEkle.CheckedState.Parent = this.btn_QRKodEkle;
            this.btn_QRKodEkle.CustomImages.Parent = this.btn_QRKodEkle;
            this.btn_QRKodEkle.FillColor = System.Drawing.Color.Transparent;
            this.btn_QRKodEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_QRKodEkle.ForeColor = System.Drawing.Color.Black;
            this.btn_QRKodEkle.HoverState.Parent = this.btn_QRKodEkle;
            this.btn_QRKodEkle.Image = global::TeknikServis_ve_Urun_Takip_Sistemi.Properties.Resources.qr_code__1_1;
            this.btn_QRKodEkle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_QRKodEkle.Location = new System.Drawing.Point(76, 147);
            this.btn_QRKodEkle.Name = "btn_QRKodEkle";
            this.btn_QRKodEkle.ShadowDecoration.Parent = this.btn_QRKodEkle;
            this.btn_QRKodEkle.Size = new System.Drawing.Size(172, 34);
            this.btn_QRKodEkle.TabIndex = 44;
            this.btn_QRKodEkle.Text = "QR Kod Oluştur";
            this.btn_QRKodEkle.UseTransparentBackground = true;
            this.btn_QRKodEkle.Click += new System.EventHandler(this.btn_QRKodEkle_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(59, 187);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(203, 190);
            this.pictureEdit1.TabIndex = 2;
            // 
            // btn_Hide
            // 
            this.btn_Hide.AutoSize = true;
            this.btn_Hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_Hide.BackgroundImage = global::TeknikServis_ve_Urun_Takip_Sistemi.Properties.Resources.hide;
            this.btn_Hide.Location = new System.Drawing.Point(283, 12);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(16, 16);
            this.btn_Hide.TabIndex = 47;
            this.btn_Hide.UseCustomBackColor = true;
            this.btn_Hide.UseCustomForeColor = true;
            this.btn_Hide.UseSelectable = true;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.AutoSize = true;
            this.btn_Kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Kapat.BackgroundImage = global::TeknikServis_ve_Urun_Takip_Sistemi.Properties.Resources.close2;
            this.btn_Kapat.Location = new System.Drawing.Point(305, 12);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(16, 16);
            this.btn_Kapat.TabIndex = 46;
            this.btn_Kapat.UseCustomBackColor = true;
            this.btn_Kapat.UseCustomForeColor = true;
            this.btn_Kapat.UseSelectable = true;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // frmQrKod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 389);
            this.Controls.Add(this.btn_Hide);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.cbx_SeriNo);
            this.Controls.Add(this.btn_QRKodEkle);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQrKod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQrKod";
            this.Load += new System.EventHandler(this.frmQrKod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Guna.UI2.WinForms.Guna2Button btn_QRKodEkle;
        private MetroFramework.Controls.MetroComboBox cbx_SeriNo;
        private MetroFramework.Controls.MetroButton btn_Hide;
        private MetroFramework.Controls.MetroButton btn_Kapat;
    }
}