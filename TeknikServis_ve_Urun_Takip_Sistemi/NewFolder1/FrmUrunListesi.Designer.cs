
namespace TeknikServis_ve_Urun_Takip_Sistemi.NewFolder1
{
    partial class FrmUrunListesi
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
            this.dgv_UrunListesi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbx_Kategoriler = new MetroFramework.Controls.MetroComboBox();
            this.tx_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
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
            this.btn_Temizle = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Listele = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Guncelle = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Sil = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Ekle = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UrunListesi)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_UrunListesi
            // 
            this.dgv_UrunListesi.AllowUserToAddRows = false;
            this.dgv_UrunListesi.AllowUserToDeleteRows = false;
            this.dgv_UrunListesi.AllowUserToResizeColumns = false;
            this.dgv_UrunListesi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv_UrunListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_UrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UrunListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgv_UrunListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_UrunListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_UrunListesi.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_UrunListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UrunListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UrunListesi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_UrunListesi.EnableHeadersVisualStyles = false;
            this.dgv_UrunListesi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgv_UrunListesi.Location = new System.Drawing.Point(1, -3);
            this.dgv_UrunListesi.Name = "dgv_UrunListesi";
            this.dgv_UrunListesi.ReadOnly = true;
            this.dgv_UrunListesi.RowHeadersVisible = false;
            this.dgv_UrunListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UrunListesi.ShowCellErrors = false;
            this.dgv_UrunListesi.ShowCellToolTips = false;
            this.dgv_UrunListesi.ShowEditingIcon = false;
            this.dgv_UrunListesi.ShowRowErrors = false;
            this.dgv_UrunListesi.Size = new System.Drawing.Size(1088, 751);
            this.dgv_UrunListesi.TabIndex = 1;
            this.dgv_UrunListesi.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgv_UrunListesi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv_UrunListesi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_UrunListesi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_UrunListesi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_UrunListesi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_UrunListesi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_UrunListesi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgv_UrunListesi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgv_UrunListesi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_UrunListesi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgv_UrunListesi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_UrunListesi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_UrunListesi.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_UrunListesi.ThemeStyle.ReadOnly = true;
            this.dgv_UrunListesi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgv_UrunListesi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_UrunListesi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgv_UrunListesi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgv_UrunListesi.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_UrunListesi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgv_UrunListesi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_UrunListesi.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UrunListesi_CellContentDoubleClick);
            this.dgv_UrunListesi.Click += new System.EventHandler(this.dgv_UrunListesi_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cbx_Kategoriler);
            this.guna2GroupBox1.Controls.Add(this.tx_ID);
            this.guna2GroupBox1.Controls.Add(this.metroLabel7);
            this.guna2GroupBox1.Controls.Add(this.btn_Temizle);
            this.guna2GroupBox1.Controls.Add(this.btn_Listele);
            this.guna2GroupBox1.Controls.Add(this.btn_Guncelle);
            this.guna2GroupBox1.Controls.Add(this.btn_Sil);
            this.guna2GroupBox1.Controls.Add(this.btn_Ekle);
            this.guna2GroupBox1.Controls.Add(this.metroLabel6);
            this.guna2GroupBox1.Controls.Add(this.metroLabel5);
            this.guna2GroupBox1.Controls.Add(this.metroLabel4);
            this.guna2GroupBox1.Controls.Add(this.metroLabel3);
            this.guna2GroupBox1.Controls.Add(this.tx_Stok);
            this.guna2GroupBox1.Controls.Add(this.tx_SatisFiyat);
            this.guna2GroupBox1.Controls.Add(this.tx_AlisFiyat);
            this.guna2GroupBox1.Controls.Add(this.metroLabel2);
            this.guna2GroupBox1.Controls.Add(this.tx_Marka);
            this.guna2GroupBox1.Controls.Add(this.metroLabel1);
            this.guna2GroupBox1.Controls.Add(this.tx_UrunAdi);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.PowderBlue;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(1095, -3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(267, 739);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Ürün İşlem Menüsü";
            // 
            // cbx_Kategoriler
            // 
            this.cbx_Kategoriler.FormattingEnabled = true;
            this.cbx_Kategoriler.ItemHeight = 23;
            this.cbx_Kategoriler.Location = new System.Drawing.Point(84, 288);
            this.cbx_Kategoriler.Name = "cbx_Kategoriler";
            this.cbx_Kategoriler.Size = new System.Drawing.Size(139, 29);
            this.cbx_Kategoriler.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbx_Kategoriler.TabIndex = 17;
            this.cbx_Kategoriler.UseSelectable = true;
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
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(4, 294);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Kategoriler:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(8, 252);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Stok:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 205);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Satış Fiyatı";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 151);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 11;
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
            this.tx_Stok.Location = new System.Drawing.Point(85, 243);
            this.tx_Stok.MaxLength = 5;
            this.tx_Stok.Name = "tx_Stok";
            this.tx_Stok.PasswordChar = '\0';
            this.tx_Stok.PlaceholderText = "";
            this.tx_Stok.SelectedText = "";
            this.tx_Stok.ShadowDecoration.Parent = this.tx_Stok;
            this.tx_Stok.Size = new System.Drawing.Size(47, 28);
            this.tx_Stok.TabIndex = 5;
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
            this.tx_SatisFiyat.Location = new System.Drawing.Point(85, 192);
            this.tx_SatisFiyat.MaxLength = 6;
            this.tx_SatisFiyat.Name = "tx_SatisFiyat";
            this.tx_SatisFiyat.PasswordChar = '\0';
            this.tx_SatisFiyat.PlaceholderText = "";
            this.tx_SatisFiyat.SelectedText = "";
            this.tx_SatisFiyat.ShadowDecoration.Parent = this.tx_SatisFiyat;
            this.tx_SatisFiyat.Size = new System.Drawing.Size(139, 28);
            this.tx_SatisFiyat.TabIndex = 4;
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
            this.tx_AlisFiyat.Location = new System.Drawing.Point(85, 137);
            this.tx_AlisFiyat.MaxLength = 6;
            this.tx_AlisFiyat.Name = "tx_AlisFiyat";
            this.tx_AlisFiyat.PasswordChar = '\0';
            this.tx_AlisFiyat.PlaceholderText = "";
            this.tx_AlisFiyat.SelectedText = "";
            this.tx_AlisFiyat.ShadowDecoration.Parent = this.tx_AlisFiyat;
            this.tx_AlisFiyat.Size = new System.Drawing.Size(139, 28);
            this.tx_AlisFiyat.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 9;
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
            this.tx_Marka.Location = new System.Drawing.Point(85, 87);
            this.tx_Marka.MaxLength = 50;
            this.tx_Marka.Name = "tx_Marka";
            this.tx_Marka.PasswordChar = '\0';
            this.tx_Marka.PlaceholderText = "";
            this.tx_Marka.SelectedText = "";
            this.tx_Marka.ShadowDecoration.Parent = this.tx_Marka;
            this.tx_Marka.Size = new System.Drawing.Size(139, 28);
            this.tx_Marka.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 7;
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
            this.tx_UrunAdi.Location = new System.Drawing.Point(85, 42);
            this.tx_UrunAdi.MaxLength = 50;
            this.tx_UrunAdi.Name = "tx_UrunAdi";
            this.tx_UrunAdi.PasswordChar = '\0';
            this.tx_UrunAdi.PlaceholderText = "";
            this.tx_UrunAdi.SelectedText = "";
            this.tx_UrunAdi.ShadowDecoration.Parent = this.tx_UrunAdi;
            this.tx_UrunAdi.Size = new System.Drawing.Size(139, 28);
            this.tx_UrunAdi.TabIndex = 1;
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
            this.btn_Temizle.Location = new System.Drawing.Point(85, 521);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.ShadowDecoration.Parent = this.btn_Temizle;
            this.btn_Temizle.Size = new System.Drawing.Size(139, 40);
            this.btn_Temizle.TabIndex = 14;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
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
            this.btn_Listele.Location = new System.Drawing.Point(84, 475);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.ShadowDecoration.Parent = this.btn_Listele;
            this.btn_Listele.Size = new System.Drawing.Size(139, 40);
            this.btn_Listele.TabIndex = 13;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
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
            this.btn_Guncelle.Location = new System.Drawing.Point(84, 429);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.ShadowDecoration.Parent = this.btn_Guncelle;
            this.btn_Guncelle.Size = new System.Drawing.Size(139, 40);
            this.btn_Guncelle.TabIndex = 13;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
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
            this.btn_Sil.Location = new System.Drawing.Point(84, 383);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.ShadowDecoration.Parent = this.btn_Sil;
            this.btn_Sil.Size = new System.Drawing.Size(139, 40);
            this.btn_Sil.TabIndex = 13;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
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
            this.btn_Ekle.Location = new System.Drawing.Point(84, 337);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.ShadowDecoration.Parent = this.btn_Ekle;
            this.btn_Ekle.Size = new System.Drawing.Size(139, 40);
            this.btn_Ekle.TabIndex = 13;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // FrmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgv_UrunListesi);
            this.Name = "FrmUrunListesi";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.FrmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UrunListesi)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_UrunListesi;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
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
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private Guna.UI2.WinForms.Guna2Button btn_Sil;
        private Guna.UI2.WinForms.Guna2Button btn_Ekle;
        private Guna.UI2.WinForms.Guna2Button btn_Guncelle;
        private Guna.UI2.WinForms.Guna2Button btn_Listele;
        private Guna.UI2.WinForms.Guna2Button btn_Temizle;
        private Guna.UI2.WinForms.Guna2TextBox tx_ID;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbx_Kategoriler;
    }
}