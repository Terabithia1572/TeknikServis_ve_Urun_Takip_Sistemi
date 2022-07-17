
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
            this.btn_QRKodEkle = new Guna.UI2.WinForms.Guna2Button();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
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
            this.btn_QRKodEkle.Location = new System.Drawing.Point(90, 107);
            this.btn_QRKodEkle.Name = "btn_QRKodEkle";
            this.btn_QRKodEkle.ShadowDecoration.Parent = this.btn_QRKodEkle;
            this.btn_QRKodEkle.Size = new System.Drawing.Size(172, 34);
            this.btn_QRKodEkle.TabIndex = 44;
            this.btn_QRKodEkle.Text = "QR Kod Oluştur";
            this.btn_QRKodEkle.UseTransparentBackground = true;
            this.btn_QRKodEkle.Click += new System.EventHandler(this.btn_QRKodEkle_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(135, 67);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(59, 147);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(220, 230);
            this.pictureEdit1.TabIndex = 2;
            // 
            // frmQrKod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 389);
            this.Controls.Add(this.btn_QRKodEkle);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQrKod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQrKod";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Guna.UI2.WinForms.Guna2Button btn_QRKodEkle;
    }
}