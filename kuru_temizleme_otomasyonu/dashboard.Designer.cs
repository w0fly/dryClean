namespace kuru_temizleme_otomasyonu
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.p_UST = new System.Windows.Forms.Panel();
            this.p_SAG = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.l_GUNUN_TOPLAMI = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_KAZANC = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_GIRIS = new System.Windows.Forms.DataGridView();
            this.p_SOL = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_TESLIM_EDILEN = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_ARA = new System.Windows.Forms.TextBox();
            this.l_ODENECEK_TUTAR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_YENILE = new System.Windows.Forms.Button();
            this.b_IPTAL_ET = new System.Windows.Forms.Button();
            this.b_TESLIM_ET = new System.Windows.Forms.Button();
            this.dgv_TESLIM_EDILECEK = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p_SAG.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KAZANC)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GIRIS)).BeginInit();
            this.p_SOL.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TESLIM_EDILEN)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TESLIM_EDILECEK)).BeginInit();
            this.SuspendLayout();
            // 
            // p_UST
            // 
            this.p_UST.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_UST.Location = new System.Drawing.Point(0, 0);
            this.p_UST.Name = "p_UST";
            this.p_UST.Size = new System.Drawing.Size(1008, 110);
            this.p_UST.TabIndex = 5;
            // 
            // p_SAG
            // 
            this.p_SAG.BackColor = System.Drawing.Color.LightSeaGreen;
            this.p_SAG.Controls.Add(this.groupBox5);
            this.p_SAG.Controls.Add(this.l_GUNUN_TOPLAMI);
            this.p_SAG.Controls.Add(this.groupBox4);
            this.p_SAG.Controls.Add(this.label2);
            this.p_SAG.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_SAG.Location = new System.Drawing.Point(620, 110);
            this.p_SAG.Name = "p_SAG";
            this.p_SAG.Size = new System.Drawing.Size(388, 571);
            this.p_SAG.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.chart1);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(6, 297);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 271);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dün - Bugün Karşılaştırma Grafiği";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 25);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.Size = new System.Drawing.Size(364, 243);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // l_GUNUN_TOPLAMI
            // 
            this.l_GUNUN_TOPLAMI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_GUNUN_TOPLAMI.AutoSize = true;
            this.l_GUNUN_TOPLAMI.ForeColor = System.Drawing.Color.Red;
            this.l_GUNUN_TOPLAMI.Location = new System.Drawing.Point(172, 273);
            this.l_GUNUN_TOPLAMI.Name = "l_GUNUN_TOPLAMI";
            this.l_GUNUN_TOPLAMI.Size = new System.Drawing.Size(19, 21);
            this.l_GUNUN_TOPLAMI.TabIndex = 17;
            this.l_GUNUN_TOPLAMI.Text = "0";
            this.l_GUNUN_TOPLAMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dgv_KAZANC);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 267);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kasa Hareketleri (Günlük)";
            // 
            // dgv_KAZANC
            // 
            this.dgv_KAZANC.AllowUserToAddRows = false;
            this.dgv_KAZANC.AllowUserToDeleteRows = false;
            this.dgv_KAZANC.AllowUserToOrderColumns = true;
            this.dgv_KAZANC.AllowUserToResizeColumns = false;
            this.dgv_KAZANC.AllowUserToResizeRows = false;
            this.dgv_KAZANC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KAZANC.BackgroundColor = System.Drawing.Color.White;
            this.dgv_KAZANC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KAZANC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KAZANC.GridColor = System.Drawing.Color.Black;
            this.dgv_KAZANC.Location = new System.Drawing.Point(3, 25);
            this.dgv_KAZANC.MultiSelect = false;
            this.dgv_KAZANC.Name = "dgv_KAZANC";
            this.dgv_KAZANC.ReadOnly = true;
            this.dgv_KAZANC.RowHeadersVisible = false;
            this.dgv_KAZANC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_KAZANC.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_KAZANC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_KAZANC.Size = new System.Drawing.Size(376, 239);
            this.dgv_KAZANC.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Günün Toplamı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgv_GIRIS);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(396, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 231);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giriş Kayıtları";
            // 
            // dgv_GIRIS
            // 
            this.dgv_GIRIS.AllowUserToAddRows = false;
            this.dgv_GIRIS.AllowUserToDeleteRows = false;
            this.dgv_GIRIS.AllowUserToOrderColumns = true;
            this.dgv_GIRIS.AllowUserToResizeColumns = false;
            this.dgv_GIRIS.AllowUserToResizeRows = false;
            this.dgv_GIRIS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GIRIS.BackgroundColor = System.Drawing.Color.White;
            this.dgv_GIRIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GIRIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_GIRIS.GridColor = System.Drawing.Color.Black;
            this.dgv_GIRIS.Location = new System.Drawing.Point(3, 25);
            this.dgv_GIRIS.MultiSelect = false;
            this.dgv_GIRIS.Name = "dgv_GIRIS";
            this.dgv_GIRIS.ReadOnly = true;
            this.dgv_GIRIS.RowHeadersVisible = false;
            this.dgv_GIRIS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_GIRIS.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_GIRIS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_GIRIS.Size = new System.Drawing.Size(212, 203);
            this.dgv_GIRIS.TabIndex = 15;
            // 
            // p_SOL
            // 
            this.p_SOL.BackColor = System.Drawing.Color.LightSeaGreen;
            this.p_SOL.Controls.Add(this.groupBox2);
            this.p_SOL.Controls.Add(this.groupBox1);
            this.p_SOL.Controls.Add(this.groupBox3);
            this.p_SOL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_SOL.Location = new System.Drawing.Point(0, 110);
            this.p_SOL.Name = "p_SOL";
            this.p_SOL.Size = new System.Drawing.Size(620, 571);
            this.p_SOL.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgv_TESLIM_EDILEN);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 231);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bugüne kadar teslim edilen ürünler";
            // 
            // dgv_TESLIM_EDILEN
            // 
            this.dgv_TESLIM_EDILEN.AllowUserToAddRows = false;
            this.dgv_TESLIM_EDILEN.AllowUserToDeleteRows = false;
            this.dgv_TESLIM_EDILEN.AllowUserToOrderColumns = true;
            this.dgv_TESLIM_EDILEN.AllowUserToResizeColumns = false;
            this.dgv_TESLIM_EDILEN.AllowUserToResizeRows = false;
            this.dgv_TESLIM_EDILEN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TESLIM_EDILEN.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TESLIM_EDILEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TESLIM_EDILEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TESLIM_EDILEN.GridColor = System.Drawing.Color.Black;
            this.dgv_TESLIM_EDILEN.Location = new System.Drawing.Point(3, 25);
            this.dgv_TESLIM_EDILEN.MultiSelect = false;
            this.dgv_TESLIM_EDILEN.Name = "dgv_TESLIM_EDILEN";
            this.dgv_TESLIM_EDILEN.ReadOnly = true;
            this.dgv_TESLIM_EDILEN.RowHeadersVisible = false;
            this.dgv_TESLIM_EDILEN.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_TESLIM_EDILEN.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TESLIM_EDILEN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TESLIM_EDILEN.Size = new System.Drawing.Size(378, 203);
            this.dgv_TESLIM_EDILEN.TabIndex = 15;
            this.dgv_TESLIM_EDILEN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TESLIM_EDILEN_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.t_ARA);
            this.groupBox1.Controls.Add(this.l_ODENECEK_TUTAR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.b_YENILE);
            this.groupBox1.Controls.Add(this.b_IPTAL_ET);
            this.groupBox1.Controls.Add(this.b_TESLIM_ET);
            this.groupBox1.Controls.Add(this.dgv_TESLIM_EDILECEK);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 328);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bugüm teslim edilecek ürünler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fiş numarası ile arama yapın :";
            // 
            // t_ARA
            // 
            this.t_ARA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_ARA.Location = new System.Drawing.Point(228, 25);
            this.t_ARA.MaxLength = 5;
            this.t_ARA.Name = "t_ARA";
            this.t_ARA.Size = new System.Drawing.Size(271, 29);
            this.t_ARA.TabIndex = 18;
            this.t_ARA.Text = "Fiş numarası ile arama yapınız.";
            this.t_ARA.Click += new System.EventHandler(this.t_ARA_Click);
            this.t_ARA.TextChanged += new System.EventHandler(this.t_ARA_TextChanged);
            this.t_ARA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ARA_KeyPress);
            // 
            // l_ODENECEK_TUTAR
            // 
            this.l_ODENECEK_TUTAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_ODENECEK_TUTAR.AutoSize = true;
            this.l_ODENECEK_TUTAR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.l_ODENECEK_TUTAR.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.l_ODENECEK_TUTAR.Location = new System.Drawing.Point(506, 261);
            this.l_ODENECEK_TUTAR.Name = "l_ODENECEK_TUTAR";
            this.l_ODENECEK_TUTAR.Size = new System.Drawing.Size(17, 19);
            this.l_ODENECEK_TUTAR.TabIndex = 17;
            this.l_ODENECEK_TUTAR.Text = "0";
            this.l_ODENECEK_TUTAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(502, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ürün seçiniz :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_YENILE
            // 
            this.b_YENILE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_YENILE.BackColor = System.Drawing.Color.Brown;
            this.b_YENILE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_YENILE.ForeColor = System.Drawing.Color.White;
            this.b_YENILE.Location = new System.Drawing.Point(505, 58);
            this.b_YENILE.Name = "b_YENILE";
            this.b_YENILE.Size = new System.Drawing.Size(95, 50);
            this.b_YENILE.TabIndex = 16;
            this.b_YENILE.Text = "Yenile";
            this.b_YENILE.UseVisualStyleBackColor = false;
            this.b_YENILE.Click += new System.EventHandler(this.b_YENILE_Click);
            // 
            // b_IPTAL_ET
            // 
            this.b_IPTAL_ET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_IPTAL_ET.BackColor = System.Drawing.Color.Brown;
            this.b_IPTAL_ET.Enabled = false;
            this.b_IPTAL_ET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_IPTAL_ET.ForeColor = System.Drawing.Color.White;
            this.b_IPTAL_ET.Location = new System.Drawing.Point(505, 170);
            this.b_IPTAL_ET.Name = "b_IPTAL_ET";
            this.b_IPTAL_ET.Size = new System.Drawing.Size(95, 50);
            this.b_IPTAL_ET.TabIndex = 16;
            this.b_IPTAL_ET.Text = "İptal Et";
            this.b_IPTAL_ET.UseVisualStyleBackColor = false;
            this.b_IPTAL_ET.Click += new System.EventHandler(this.b_IPTAL_ET_Click);
            // 
            // b_TESLIM_ET
            // 
            this.b_TESLIM_ET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_TESLIM_ET.BackColor = System.Drawing.Color.Brown;
            this.b_TESLIM_ET.Enabled = false;
            this.b_TESLIM_ET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_TESLIM_ET.ForeColor = System.Drawing.Color.White;
            this.b_TESLIM_ET.Location = new System.Drawing.Point(505, 114);
            this.b_TESLIM_ET.Name = "b_TESLIM_ET";
            this.b_TESLIM_ET.Size = new System.Drawing.Size(95, 50);
            this.b_TESLIM_ET.TabIndex = 16;
            this.b_TESLIM_ET.Text = "Teslim Et";
            this.b_TESLIM_ET.UseVisualStyleBackColor = false;
            this.b_TESLIM_ET.Click += new System.EventHandler(this.b_TESLIM_ET_Click);
            // 
            // dgv_TESLIM_EDILECEK
            // 
            this.dgv_TESLIM_EDILECEK.AllowUserToAddRows = false;
            this.dgv_TESLIM_EDILECEK.AllowUserToDeleteRows = false;
            this.dgv_TESLIM_EDILECEK.AllowUserToOrderColumns = true;
            this.dgv_TESLIM_EDILECEK.AllowUserToResizeColumns = false;
            this.dgv_TESLIM_EDILECEK.AllowUserToResizeRows = false;
            this.dgv_TESLIM_EDILECEK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TESLIM_EDILECEK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TESLIM_EDILECEK.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TESLIM_EDILECEK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TESLIM_EDILECEK.GridColor = System.Drawing.Color.Black;
            this.dgv_TESLIM_EDILECEK.Location = new System.Drawing.Point(3, 58);
            this.dgv_TESLIM_EDILECEK.MultiSelect = false;
            this.dgv_TESLIM_EDILECEK.Name = "dgv_TESLIM_EDILECEK";
            this.dgv_TESLIM_EDILECEK.ReadOnly = true;
            this.dgv_TESLIM_EDILECEK.RowHeadersVisible = false;
            this.dgv_TESLIM_EDILECEK.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_TESLIM_EDILECEK.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TESLIM_EDILECEK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_TESLIM_EDILECEK.Size = new System.Drawing.Size(496, 264);
            this.dgv_TESLIM_EDILECEK.TabIndex = 15;
            this.dgv_TESLIM_EDILECEK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TESLIM_EDILECEK_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.p_SOL);
            this.Controls.Add(this.p_SAG);
            this.Controls.Add(this.p_UST);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuru Temizleme Takip Programı v1.0 Gösterge Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Form_dashboard_Load);
            this.p_SAG.ResumeLayout(false);
            this.p_SAG.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KAZANC)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GIRIS)).EndInit();
            this.p_SOL.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TESLIM_EDILEN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TESLIM_EDILECEK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_UST;
        private System.Windows.Forms.Panel p_SAG;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label l_GUNUN_TOPLAMI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel p_SOL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_ODENECEK_TUTAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_IPTAL_ET;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox t_ARA;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgv_TESLIM_EDILECEK;
        public System.Windows.Forms.Button b_TESLIM_ET;
        public System.Windows.Forms.Button b_YENILE;
        public System.Windows.Forms.DataGridView dgv_KAZANC;
        public System.Windows.Forms.DataGridView dgv_GIRIS;
        public System.Windows.Forms.DataGridView dgv_TESLIM_EDILEN;
        private System.Windows.Forms.Timer timer1;

    }
}