
namespace TeknikServis_ve_Urun_Takip_Sistemi.NewFolder1
{
    partial class frmMarkalar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView3 = new DevExpress.XtraCharts.PieSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarkalar));
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_EnFazlaStokluUrun = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.dgv_MarkaListesi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_ToplamMarkaSayisi = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_EnFazlaUrunuOlanMarka = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_EnYuksekFiyatliMarka = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MarkaListesi)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.guna2Panel6.Controls.Add(this.lbl_EnFazlaStokluUrun);
            this.guna2Panel6.Controls.Add(this.metroLabel11);
            this.guna2Panel6.Location = new System.Drawing.Point(453, 0);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(215, 110);
            this.guna2Panel6.TabIndex = 11;
            // 
            // lbl_EnFazlaStokluUrun
            // 
            this.lbl_EnFazlaStokluUrun.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EnFazlaStokluUrun.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_EnFazlaStokluUrun.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_EnFazlaStokluUrun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_EnFazlaStokluUrun.Location = new System.Drawing.Point(9, 51);
            this.lbl_EnFazlaStokluUrun.Name = "lbl_EnFazlaStokluUrun";
            this.lbl_EnFazlaStokluUrun.Size = new System.Drawing.Size(152, 59);
            this.lbl_EnFazlaStokluUrun.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbl_EnFazlaStokluUrun.TabIndex = 1;
            this.lbl_EnFazlaStokluUrun.Text = "Bilgisayar";
            this.lbl_EnFazlaStokluUrun.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbl_EnFazlaStokluUrun.UseCustomBackColor = true;
            this.lbl_EnFazlaStokluUrun.UseCustomForeColor = true;
            this.lbl_EnFazlaStokluUrun.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel11.Location = new System.Drawing.Point(9, 9);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(119, 19);
            this.metroLabel11.TabIndex = 0;
            this.metroLabel11.Text = "Toplam Ürün Sayısı";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            this.metroLabel11.UseStyleColors = true;
            // 
            // dgv_MarkaListesi
            // 
            this.dgv_MarkaListesi.AllowUserToAddRows = false;
            this.dgv_MarkaListesi.AllowUserToDeleteRows = false;
            this.dgv_MarkaListesi.AllowUserToResizeColumns = false;
            this.dgv_MarkaListesi.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv_MarkaListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_MarkaListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MarkaListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgv_MarkaListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_MarkaListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_MarkaListesi.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_MarkaListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MarkaListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_MarkaListesi.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_MarkaListesi.EnableHeadersVisualStyles = false;
            this.dgv_MarkaListesi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgv_MarkaListesi.Location = new System.Drawing.Point(7, 0);
            this.dgv_MarkaListesi.Name = "dgv_MarkaListesi";
            this.dgv_MarkaListesi.ReadOnly = true;
            this.dgv_MarkaListesi.RowHeadersVisible = false;
            this.dgv_MarkaListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MarkaListesi.ShowCellErrors = false;
            this.dgv_MarkaListesi.ShowCellToolTips = false;
            this.dgv_MarkaListesi.ShowEditingIcon = false;
            this.dgv_MarkaListesi.ShowRowErrors = false;
            this.dgv_MarkaListesi.Size = new System.Drawing.Size(440, 736);
            this.dgv_MarkaListesi.TabIndex = 10;
            this.dgv_MarkaListesi.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgv_MarkaListesi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv_MarkaListesi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_MarkaListesi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_MarkaListesi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_MarkaListesi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_MarkaListesi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_MarkaListesi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgv_MarkaListesi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgv_MarkaListesi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_MarkaListesi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgv_MarkaListesi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_MarkaListesi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_MarkaListesi.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_MarkaListesi.ThemeStyle.ReadOnly = true;
            this.dgv_MarkaListesi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgv_MarkaListesi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_MarkaListesi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgv_MarkaListesi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgv_MarkaListesi.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_MarkaListesi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgv_MarkaListesi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.guna2Panel1.Controls.Add(this.lbl_ToplamMarkaSayisi);
            this.guna2Panel1.Controls.Add(this.metroLabel2);
            this.guna2Panel1.Location = new System.Drawing.Point(674, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(215, 110);
            this.guna2Panel1.TabIndex = 12;
            // 
            // lbl_ToplamMarkaSayisi
            // 
            this.lbl_ToplamMarkaSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ToplamMarkaSayisi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_ToplamMarkaSayisi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_ToplamMarkaSayisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ToplamMarkaSayisi.Location = new System.Drawing.Point(9, 51);
            this.lbl_ToplamMarkaSayisi.Name = "lbl_ToplamMarkaSayisi";
            this.lbl_ToplamMarkaSayisi.Size = new System.Drawing.Size(152, 59);
            this.lbl_ToplamMarkaSayisi.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbl_ToplamMarkaSayisi.TabIndex = 1;
            this.lbl_ToplamMarkaSayisi.Text = "Bilgisayar";
            this.lbl_ToplamMarkaSayisi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbl_ToplamMarkaSayisi.UseCustomBackColor = true;
            this.lbl_ToplamMarkaSayisi.UseCustomForeColor = true;
            this.lbl_ToplamMarkaSayisi.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel2.Location = new System.Drawing.Point(9, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Toplam Marka Sayısı";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.guna2Panel2.Controls.Add(this.lbl_EnFazlaUrunuOlanMarka);
            this.guna2Panel2.Controls.Add(this.metroLabel4);
            this.guna2Panel2.Location = new System.Drawing.Point(895, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(215, 110);
            this.guna2Panel2.TabIndex = 13;
            // 
            // lbl_EnFazlaUrunuOlanMarka
            // 
            this.lbl_EnFazlaUrunuOlanMarka.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EnFazlaUrunuOlanMarka.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_EnFazlaUrunuOlanMarka.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_EnFazlaUrunuOlanMarka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_EnFazlaUrunuOlanMarka.Location = new System.Drawing.Point(9, 51);
            this.lbl_EnFazlaUrunuOlanMarka.Name = "lbl_EnFazlaUrunuOlanMarka";
            this.lbl_EnFazlaUrunuOlanMarka.Size = new System.Drawing.Size(152, 59);
            this.lbl_EnFazlaUrunuOlanMarka.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbl_EnFazlaUrunuOlanMarka.TabIndex = 1;
            this.lbl_EnFazlaUrunuOlanMarka.Text = "Vestel";
            this.lbl_EnFazlaUrunuOlanMarka.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbl_EnFazlaUrunuOlanMarka.UseCustomBackColor = true;
            this.lbl_EnFazlaUrunuOlanMarka.UseCustomForeColor = true;
            this.lbl_EnFazlaUrunuOlanMarka.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel4.Location = new System.Drawing.Point(9, 9);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(168, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "En Fazla Ürünü Olan Marka";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(166)))), ((int)(((byte)(157)))));
            this.guna2Panel3.Controls.Add(this.lbl_EnYuksekFiyatliMarka);
            this.guna2Panel3.Controls.Add(this.metroLabel6);
            this.guna2Panel3.Location = new System.Drawing.Point(1116, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(241, 110);
            this.guna2Panel3.TabIndex = 14;
            // 
            // lbl_EnYuksekFiyatliMarka
            // 
            this.lbl_EnYuksekFiyatliMarka.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EnYuksekFiyatliMarka.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_EnYuksekFiyatliMarka.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_EnYuksekFiyatliMarka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_EnYuksekFiyatliMarka.Location = new System.Drawing.Point(9, 51);
            this.lbl_EnYuksekFiyatliMarka.Name = "lbl_EnYuksekFiyatliMarka";
            this.lbl_EnYuksekFiyatliMarka.Size = new System.Drawing.Size(152, 59);
            this.lbl_EnYuksekFiyatliMarka.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbl_EnYuksekFiyatliMarka.TabIndex = 1;
            this.lbl_EnYuksekFiyatliMarka.Text = "Xiamio";
            this.lbl_EnYuksekFiyatliMarka.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbl_EnYuksekFiyatliMarka.UseCustomBackColor = true;
            this.lbl_EnYuksekFiyatliMarka.UseCustomForeColor = true;
            this.lbl_EnYuksekFiyatliMarka.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel6.Location = new System.Drawing.Point(9, 9);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(144, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "En Yüksek Fiyatlı Marka";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.metroLabel3);
            this.guna2Panel4.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel4.Controls.Add(this.metroLabel1);
            this.guna2Panel4.Controls.Add(this.chartControl1);
            this.guna2Panel4.Controls.Add(this.guna2Panel7);
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.Location = new System.Drawing.Point(449, 126);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(436, 609);
            this.guna2Panel4.TabIndex = 15;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Location = new System.Drawing.Point(900, 126);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(452, 501);
            this.guna2Panel5.TabIndex = 0;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Location = new System.Drawing.Point(901, 633);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.ShadowDecoration.Parent = this.guna2Panel7;
            this.guna2Panel7.Size = new System.Drawing.Size(452, 98);
            this.guna2Panel7.TabIndex = 1;
            // 
            // chartControl1
            // 
            this.chartControl1.Location = new System.Drawing.Point(3, 3);
            this.chartControl1.Name = "chartControl1";
            series3.Name = "Series 1";
            series3.View = pieSeriesView3;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl1.Size = new System.Drawing.Size(430, 603);
            this.chartControl1.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(84, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(192, 47);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Marka Ve İstatistikleri";
            this.metroLabel1.UseStyleColors = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.ErrorImage")));
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::TeknikServis_ve_Urun_Takip_Sistemi.Properties.Resources.analytics;
            this.guna2PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.InitialImage")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(14, 17);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(53, 47);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(13, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(328, 103);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Projemizin Bu Bölümünde Markalar ve Bu Markalara Ait \r\nİstatistik Değerlerine Bir" +
    " Chart yani Grafik Alanı Üzerinden\r\nGüçlü Bir Arayüz İle Ulaşabilirsiniz.";
            // 
            // frmMarkalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel6);
            this.Controls.Add(this.dgv_MarkaListesi);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel3);
            this.Name = "frmMarkalar";
            this.Text = "Markalar";
            this.Load += new System.EventHandler(this.frmMarkalar_Load);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MarkaListesi)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private MetroFramework.Controls.MetroLabel lbl_EnFazlaStokluUrun;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_MarkaListesi;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private MetroFramework.Controls.MetroLabel lbl_ToplamMarkaSayisi;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private MetroFramework.Controls.MetroLabel lbl_EnFazlaUrunuOlanMarka;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private MetroFramework.Controls.MetroLabel lbl_EnYuksekFiyatliMarka;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}