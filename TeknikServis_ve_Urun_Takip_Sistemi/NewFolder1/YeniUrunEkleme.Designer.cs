
namespace TeknikServis_ve_Urun_Takip_Sistemi.NewFolder1
{
    partial class YeniUrunEkleme
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
            this.btn_Vazgeç = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Ekle = new Guna.UI2.WinForms.Guna2Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tx_Stok = new Guna.UI2.WinForms.Guna2TextBox();
            this.tx_SatisFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.tx_AlisFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tx_Marka = new Guna.UI2.WinForms.Guna2TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tx_UrunAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbx_Kategoriler = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btn_Vazgeç
            // 
            this.btn_Vazgeç.CheckedState.Parent = this.btn_Vazgeç;
            this.btn_Vazgeç.CustomImages.Parent = this.btn_Vazgeç;
            this.btn_Vazgeç.FillColor = System.Drawing.Color.White;
            this.btn_Vazgeç.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Vazgeç.ForeColor = System.Drawing.Color.Black;
            this.btn_Vazgeç.HoverState.Parent = this.btn_Vazgeç;
            this.btn_Vazgeç.Image = global::TeknikServis_ve_Urun_Takip_Sistemi.Properties.Resources.distributed;
            this.btn_Vazgeç.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Vazgeç.Location = new System.Drawing.Point(307, 159);
            this.btn_Vazgeç.Name = "btn_Vazgeç";
            this.btn_Vazgeç.ShadowDecoration.Parent = this.btn_Vazgeç;
            this.btn_Vazgeç.Size = new System.Drawing.Size(139, 40);
            this.btn_Vazgeç.TabIndex = 30;
            this.btn_Vazgeç.Text = "             Ürün Listesini Aç";
            this.btn_Vazgeç.Click += new System.EventHandler(this.btn_Vazgeç_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.CheckedState.Parent = this.btn_Ekle;
            this.btn_Ekle.CustomImages.Parent = this.btn_Ekle;
            this.btn_Ekle.FillColor = System.Drawing.Color.White;
            this.btn_Ekle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Ekle.ForeColor = System.Drawing.Color.Black;
            this.btn_Ekle.HoverState.Parent = this.btn_Ekle;
            this.btn_Ekle.Image = global::TeknikServis_ve_Urun_Takip_Sistemi.Properties.Resources.add_to_cart;
            this.btn_Ekle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Ekle.Location = new System.Drawing.Point(307, 113);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.ShadowDecoration.Parent = this.btn_Ekle;
            this.btn_Ekle.Size = new System.Drawing.Size(139, 40);
            this.btn_Ekle.TabIndex = 29;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(49, 292);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 27;
            this.metroLabel5.Text = "Stok:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(44, 245);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Satış Fiyatı";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(44, 191);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Alış Fiyatı:";
            // 
            // tx_Stok
            // 
            this.tx_Stok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_Stok.DefaultText = "";
            this.tx_Stok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_Stok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_Stok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_Stok.DisabledState.Parent = this.tx_Stok;
            this.tx_Stok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_Stok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_Stok.FocusedState.Parent = this.tx_Stok;
            this.tx_Stok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_Stok.HoverState.Parent = this.tx_Stok;
            this.tx_Stok.Location = new System.Drawing.Point(126, 283);
            this.tx_Stok.Name = "tx_Stok";
            this.tx_Stok.PasswordChar = '\0';
            this.tx_Stok.PlaceholderText = "";
            this.tx_Stok.SelectedText = "";
            this.tx_Stok.ShadowDecoration.Parent = this.tx_Stok;
            this.tx_Stok.Size = new System.Drawing.Size(47, 28);
            this.tx_Stok.TabIndex = 22;
            // 
            // tx_SatisFiyat
            // 
            this.tx_SatisFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_SatisFiyat.DefaultText = "";
            this.tx_SatisFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_SatisFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_SatisFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_SatisFiyat.DisabledState.Parent = this.tx_SatisFiyat;
            this.tx_SatisFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_SatisFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_SatisFiyat.FocusedState.Parent = this.tx_SatisFiyat;
            this.tx_SatisFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_SatisFiyat.HoverState.Parent = this.tx_SatisFiyat;
            this.tx_SatisFiyat.Location = new System.Drawing.Point(126, 232);
            this.tx_SatisFiyat.Name = "tx_SatisFiyat";
            this.tx_SatisFiyat.PasswordChar = '\0';
            this.tx_SatisFiyat.PlaceholderText = "";
            this.tx_SatisFiyat.SelectedText = "";
            this.tx_SatisFiyat.ShadowDecoration.Parent = this.tx_SatisFiyat;
            this.tx_SatisFiyat.Size = new System.Drawing.Size(139, 28);
            this.tx_SatisFiyat.TabIndex = 21;
            // 
            // tx_AlisFiyat
            // 
            this.tx_AlisFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_AlisFiyat.DefaultText = "";
            this.tx_AlisFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_AlisFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_AlisFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_AlisFiyat.DisabledState.Parent = this.tx_AlisFiyat;
            this.tx_AlisFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_AlisFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_AlisFiyat.FocusedState.Parent = this.tx_AlisFiyat;
            this.tx_AlisFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_AlisFiyat.HoverState.Parent = this.tx_AlisFiyat;
            this.tx_AlisFiyat.Location = new System.Drawing.Point(126, 177);
            this.tx_AlisFiyat.Name = "tx_AlisFiyat";
            this.tx_AlisFiyat.PasswordChar = '\0';
            this.tx_AlisFiyat.PlaceholderText = "";
            this.tx_AlisFiyat.SelectedText = "";
            this.tx_AlisFiyat.ShadowDecoration.Parent = this.tx_AlisFiyat;
            this.tx_AlisFiyat.Size = new System.Drawing.Size(139, 28);
            this.tx_AlisFiyat.TabIndex = 20;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(44, 137);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Marka:";
            // 
            // tx_Marka
            // 
            this.tx_Marka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_Marka.DefaultText = "";
            this.tx_Marka.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_Marka.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_Marka.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_Marka.DisabledState.Parent = this.tx_Marka;
            this.tx_Marka.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_Marka.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_Marka.FocusedState.Parent = this.tx_Marka;
            this.tx_Marka.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_Marka.HoverState.Parent = this.tx_Marka;
            this.tx_Marka.Location = new System.Drawing.Point(125, 133);
            this.tx_Marka.Name = "tx_Marka";
            this.tx_Marka.PasswordChar = '\0';
            this.tx_Marka.PlaceholderText = "";
            this.tx_Marka.SelectedText = "";
            this.tx_Marka.ShadowDecoration.Parent = this.tx_Marka;
            this.tx_Marka.Size = new System.Drawing.Size(139, 28);
            this.tx_Marka.TabIndex = 19;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 49);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Ürün Adı:";
            // 
            // tx_UrunAdi
            // 
            this.tx_UrunAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_UrunAdi.DefaultText = "";
            this.tx_UrunAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_UrunAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_UrunAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_UrunAdi.DisabledState.Parent = this.tx_UrunAdi;
            this.tx_UrunAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_UrunAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_UrunAdi.FocusedState.Parent = this.tx_UrunAdi;
            this.tx_UrunAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_UrunAdi.HoverState.Parent = this.tx_UrunAdi;
            this.tx_UrunAdi.Location = new System.Drawing.Point(126, 44);
            this.tx_UrunAdi.Name = "tx_UrunAdi";
            this.tx_UrunAdi.PasswordChar = '\0';
            this.tx_UrunAdi.PlaceholderText = "";
            this.tx_UrunAdi.SelectedText = "";
            this.tx_UrunAdi.ShadowDecoration.Parent = this.tx_UrunAdi;
            this.tx_UrunAdi.Size = new System.Drawing.Size(139, 28);
            this.tx_UrunAdi.TabIndex = 18;
            // 
            // cbx_Kategoriler
            // 
            this.cbx_Kategoriler.FormattingEnabled = true;
            this.cbx_Kategoriler.ItemHeight = 23;
            this.cbx_Kategoriler.Location = new System.Drawing.Point(125, 89);
            this.cbx_Kategoriler.Name = "cbx_Kategoriler";
            this.cbx_Kategoriler.Size = new System.Drawing.Size(139, 29);
            this.cbx_Kategoriler.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbx_Kategoriler.TabIndex = 32;
            this.cbx_Kategoriler.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(45, 95);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 19);
            this.metroLabel6.TabIndex = 31;
            this.metroLabel6.Text = "Kategoriler:";
            // 
            // YeniUrunEkleme
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 360);
            this.Controls.Add(this.cbx_Kategoriler);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btn_Vazgeç);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tx_Stok);
            this.Controls.Add(this.tx_SatisFiyat);
            this.Controls.Add(this.tx_AlisFiyat);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tx_Marka);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tx_UrunAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YeniUrunEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniUrunEkleme";
            this.Load += new System.EventHandler(this.YeniUrunEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_Vazgeç;
        private Guna.UI2.WinForms.Guna2Button btn_Ekle;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private Guna.UI2.WinForms.Guna2TextBox tx_Stok;
        private Guna.UI2.WinForms.Guna2TextBox tx_SatisFiyat;
        private Guna.UI2.WinForms.Guna2TextBox tx_AlisFiyat;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Guna.UI2.WinForms.Guna2TextBox tx_Marka;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tx_UrunAdi;
        private MetroFramework.Controls.MetroComboBox cbx_Kategoriler;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}