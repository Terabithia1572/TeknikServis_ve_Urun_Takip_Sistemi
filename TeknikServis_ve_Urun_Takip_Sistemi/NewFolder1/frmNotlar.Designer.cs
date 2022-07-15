
namespace TeknikServis_ve_Urun_Takip_Sistemi.NewFolder1
{
    partial class frmNotlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_OkunanNotlar = new MetroFramework.Controls.MetroLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tx_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btn_Temizle = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Listele = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Guncelle = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Sil = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Ekle = new Guna.UI2.WinForms.Guna2Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tx_UrunAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dgv_OkunmayanNotlar = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgv_OkunanNotlar = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OkunmayanNotlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OkunanNotlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_OkunanNotlar
            // 
            this.lbl_OkunanNotlar.Location = new System.Drawing.Point(3, 11);
            this.lbl_OkunanNotlar.Name = "lbl_OkunanNotlar";
            this.lbl_OkunanNotlar.Size = new System.Drawing.Size(1019, 22);
            this.lbl_OkunanNotlar.TabIndex = 1;
            this.lbl_OkunanNotlar.Text = "Okunmayan Notlar";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.metroLabel3);
            this.guna2GroupBox1.Controls.Add(this.guna2CheckBox1);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox1);
            this.guna2GroupBox1.Controls.Add(this.tx_ID);
            this.guna2GroupBox1.Controls.Add(this.metroLabel7);
            this.guna2GroupBox1.Controls.Add(this.btn_Temizle);
            this.guna2GroupBox1.Controls.Add(this.btn_Listele);
            this.guna2GroupBox1.Controls.Add(this.btn_Guncelle);
            this.guna2GroupBox1.Controls.Add(this.btn_Sil);
            this.guna2GroupBox1.Controls.Add(this.btn_Ekle);
            this.guna2GroupBox1.Controls.Add(this.metroLabel2);
            this.guna2GroupBox1.Controls.Add(this.metroLabel1);
            this.guna2GroupBox1.Controls.Add(this.tx_UrunAdi);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.PowderBlue;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(1028, 22);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(324, 708);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Not İşlem Menüsü";
            // 
            // tx_ID
            // 
            this.tx_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_ID.DefaultText = "";
            this.tx_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_ID.DisabledState.Parent = this.tx_ID;
            this.tx_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_ID.Enabled = false;
            this.tx_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_ID.FocusedState.Parent = this.tx_ID;
            this.tx_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_ID.HoverState.Parent = this.tx_ID;
            this.tx_ID.Location = new System.Drawing.Point(230, 42);
            this.tx_ID.Name = "tx_ID";
            this.tx_ID.PasswordChar = '\0';
            this.tx_ID.PlaceholderText = "";
            this.tx_ID.SelectedText = "";
            this.tx_ID.ShadowDecoration.Parent = this.tx_ID;
            this.tx_ID.Size = new System.Drawing.Size(34, 29);
            this.tx_ID.TabIndex = 16;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(236, 74);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(21, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "ID";
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.CheckedState.Parent = this.btn_Temizle;
            this.btn_Temizle.CustomImages.Parent = this.btn_Temizle;
            this.btn_Temizle.FillColor = System.Drawing.Color.White;
            this.btn_Temizle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Temizle.ForeColor = System.Drawing.Color.Black;
            this.btn_Temizle.HoverState.Parent = this.btn_Temizle;
            this.btn_Temizle.Image = global::TeknikServis_ve_Urun_Takip_Sistemi.Properties.Resources.remove_cart;
            this.btn_Temizle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Temizle.Location = new System.Drawing.Point(85, 485);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.ShadowDecoration.Parent = this.btn_Temizle;
            this.btn_Temizle.Size = new System.Drawing.Size(139, 40);
            this.btn_Temizle.TabIndex = 14;
            this.btn_Temizle.Text = "Temizle";
            // 
            // btn_Listele
            // 
            this.btn_Listele.CheckedState.Parent = this.btn_Listele;
            this.btn_Listele.CustomImages.Parent = this.btn_Listele;
            this.btn_Listele.FillColor = System.Drawing.Color.White;
            this.btn_Listele.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Listele.ForeColor = System.Drawing.Color.Black;
            this.btn_Listele.HoverState.Parent = this.btn_Listele;
            this.btn_Listele.Image = global::TeknikServis_ve_Urun_Takip_Sistemi.Properties.Resources.shopping_cart__2_;
            this.btn_Listele.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Listele.Location = new System.Drawing.Point(85, 439);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.ShadowDecoration.Parent = this.btn_Listele;
            this.btn_Listele.Size = new System.Drawing.Size(139, 40);
            this.btn_Listele.TabIndex = 13;
            this.btn_Listele.Text = "Listele";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.CheckedState.Parent = this.btn_Guncelle;
            this.btn_Guncelle.CustomImages.Parent = this.btn_Guncelle;
            this.btn_Guncelle.FillColor = System.Drawing.Color.White;
            this.btn_Guncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Guncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_Guncelle.HoverState.Parent = this.btn_Guncelle;
            this.btn_Guncelle.Image = global::TeknikServis_ve_Urun_Takip_Sistemi.Properties.Resources.purchase;
            this.btn_Guncelle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Guncelle.Location = new System.Drawing.Point(85, 393);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.ShadowDecoration.Parent = this.btn_Guncelle;
            this.btn_Guncelle.Size = new System.Drawing.Size(139, 40);
            this.btn_Guncelle.TabIndex = 13;
            this.btn_Guncelle.Text = "Güncelle";
            // 
            // btn_Sil
            // 
            this.btn_Sil.CheckedState.Parent = this.btn_Sil;
            this.btn_Sil.CustomImages.Parent = this.btn_Sil;
            this.btn_Sil.FillColor = System.Drawing.Color.White;
            this.btn_Sil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sil.ForeColor = System.Drawing.Color.Black;
            this.btn_Sil.HoverState.Parent = this.btn_Sil;
            this.btn_Sil.Image = global::TeknikServis_ve_Urun_Takip_Sistemi.Properties.Resources.remove_from_cart__1_;
            this.btn_Sil.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Sil.Location = new System.Drawing.Point(85, 347);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.ShadowDecoration.Parent = this.btn_Sil;
            this.btn_Sil.Size = new System.Drawing.Size(139, 40);
            this.btn_Sil.TabIndex = 13;
            this.btn_Sil.Text = "Sil";
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
            this.btn_Ekle.Location = new System.Drawing.Point(85, 301);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.ShadowDecoration.Parent = this.btn_Ekle;
            this.btn_Ekle.Size = new System.Drawing.Size(139, 40);
            this.btn_Ekle.TabIndex = 13;
            this.btn_Ekle.Text = "Ekle";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "İçerik:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Başlık:";
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
            this.tx_UrunAdi.Location = new System.Drawing.Point(85, 42);
            this.tx_UrunAdi.Name = "tx_UrunAdi";
            this.tx_UrunAdi.PasswordChar = '\0';
            this.tx_UrunAdi.PlaceholderText = "";
            this.tx_UrunAdi.SelectedText = "";
            this.tx_UrunAdi.ShadowDecoration.Parent = this.tx_UrunAdi;
            this.tx_UrunAdi.Size = new System.Drawing.Size(139, 28);
            this.tx_UrunAdi.TabIndex = 1;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(61, 97);
            this.guna2TextBox1.Multiline = true;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(236, 155);
            this.guna2TextBox1.TabIndex = 18;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoCheck = false;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2CheckBox1.Location = new System.Drawing.Point(61, 272);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(177, 23);
            this.guna2CheckBox1.TabIndex = 19;
            this.guna2CheckBox1.Text = "Okundu Olarak İşaretle";
            this.guna2CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UseVisualStyleBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 272);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Durum:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(3, 263);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(1019, 20);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Okunan Notlar";
            // 
            // dgv_OkunmayanNotlar
            // 
            this.dgv_OkunmayanNotlar.AllowUserToAddRows = false;
            this.dgv_OkunmayanNotlar.AllowUserToDeleteRows = false;
            this.dgv_OkunmayanNotlar.AllowUserToResizeColumns = false;
            this.dgv_OkunmayanNotlar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv_OkunmayanNotlar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_OkunmayanNotlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_OkunmayanNotlar.BackgroundColor = System.Drawing.Color.White;
            this.dgv_OkunmayanNotlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_OkunmayanNotlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_OkunmayanNotlar.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_OkunmayanNotlar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_OkunmayanNotlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_OkunmayanNotlar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_OkunmayanNotlar.EnableHeadersVisualStyles = false;
            this.dgv_OkunmayanNotlar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgv_OkunmayanNotlar.Location = new System.Drawing.Point(3, 32);
            this.dgv_OkunmayanNotlar.Name = "dgv_OkunmayanNotlar";
            this.dgv_OkunmayanNotlar.ReadOnly = true;
            this.dgv_OkunmayanNotlar.RowHeadersVisible = false;
            this.dgv_OkunmayanNotlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OkunmayanNotlar.ShowCellErrors = false;
            this.dgv_OkunmayanNotlar.ShowCellToolTips = false;
            this.dgv_OkunmayanNotlar.ShowEditingIcon = false;
            this.dgv_OkunmayanNotlar.ShowRowErrors = false;
            this.dgv_OkunmayanNotlar.Size = new System.Drawing.Size(1019, 228);
            this.dgv_OkunmayanNotlar.TabIndex = 6;
            this.dgv_OkunmayanNotlar.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgv_OkunmayanNotlar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv_OkunmayanNotlar.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_OkunmayanNotlar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_OkunmayanNotlar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_OkunmayanNotlar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_OkunmayanNotlar.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_OkunmayanNotlar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgv_OkunmayanNotlar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgv_OkunmayanNotlar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_OkunmayanNotlar.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgv_OkunmayanNotlar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_OkunmayanNotlar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_OkunmayanNotlar.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_OkunmayanNotlar.ThemeStyle.ReadOnly = true;
            this.dgv_OkunmayanNotlar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgv_OkunmayanNotlar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_OkunmayanNotlar.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgv_OkunmayanNotlar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgv_OkunmayanNotlar.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_OkunmayanNotlar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgv_OkunmayanNotlar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dgv_OkunanNotlar
            // 
            this.dgv_OkunanNotlar.AllowUserToAddRows = false;
            this.dgv_OkunanNotlar.AllowUserToDeleteRows = false;
            this.dgv_OkunanNotlar.AllowUserToResizeColumns = false;
            this.dgv_OkunanNotlar.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv_OkunanNotlar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_OkunanNotlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_OkunanNotlar.BackgroundColor = System.Drawing.Color.White;
            this.dgv_OkunanNotlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_OkunanNotlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_OkunanNotlar.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_OkunanNotlar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_OkunanNotlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_OkunanNotlar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_OkunanNotlar.EnableHeadersVisualStyles = false;
            this.dgv_OkunanNotlar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgv_OkunanNotlar.Location = new System.Drawing.Point(0, 284);
            this.dgv_OkunanNotlar.Name = "dgv_OkunanNotlar";
            this.dgv_OkunanNotlar.ReadOnly = true;
            this.dgv_OkunanNotlar.RowHeadersVisible = false;
            this.dgv_OkunanNotlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OkunanNotlar.ShowCellErrors = false;
            this.dgv_OkunanNotlar.ShowCellToolTips = false;
            this.dgv_OkunanNotlar.ShowEditingIcon = false;
            this.dgv_OkunanNotlar.ShowRowErrors = false;
            this.dgv_OkunanNotlar.Size = new System.Drawing.Size(1022, 253);
            this.dgv_OkunanNotlar.TabIndex = 7;
            this.dgv_OkunanNotlar.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgv_OkunanNotlar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv_OkunanNotlar.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_OkunanNotlar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_OkunanNotlar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_OkunanNotlar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_OkunanNotlar.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_OkunanNotlar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgv_OkunanNotlar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgv_OkunanNotlar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_OkunanNotlar.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgv_OkunanNotlar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_OkunanNotlar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_OkunanNotlar.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_OkunanNotlar.ThemeStyle.ReadOnly = true;
            this.dgv_OkunanNotlar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgv_OkunanNotlar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_OkunanNotlar.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgv_OkunanNotlar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgv_OkunanNotlar.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_OkunanNotlar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgv_OkunanNotlar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // frmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.dgv_OkunanNotlar);
            this.Controls.Add(this.dgv_OkunmayanNotlar);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lbl_OkunanNotlar);
            this.Name = "frmNotlar";
            this.Text = "frmNotlar";
            this.Load += new System.EventHandler(this.frmNotlar_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OkunmayanNotlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OkunanNotlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lbl_OkunanNotlar;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox tx_ID;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private Guna.UI2.WinForms.Guna2Button btn_Temizle;
        private Guna.UI2.WinForms.Guna2Button btn_Listele;
        private Guna.UI2.WinForms.Guna2Button btn_Guncelle;
        private Guna.UI2.WinForms.Guna2Button btn_Sil;
        private Guna.UI2.WinForms.Guna2Button btn_Ekle;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tx_UrunAdi;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_OkunmayanNotlar;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_OkunanNotlar;
    }
}