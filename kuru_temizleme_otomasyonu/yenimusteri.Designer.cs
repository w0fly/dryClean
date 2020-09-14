namespace kuru_temizleme_otomasyonu
{
    partial class yenimusteri
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
            this.t_AD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_ADRES = new System.Windows.Forms.RichTextBox();
            this.t_TEL = new System.Windows.Forms.TextBox();
            this.b_MUSTERI_EKLE = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_MUSTERI_EKLE = new System.Windows.Forms.GroupBox();
            this.dgv_MUSTERI = new System.Windows.Forms.DataGridView();
            this.t_ARA = new System.Windows.Forms.TextBox();
            this.c_MUSTERI_KAYITLIYSA = new System.Windows.Forms.CheckBox();
            this.c_ODEME_YAPILDIYSA = new System.Windows.Forms.CheckBox();
            this.d_TESLIM_TARIHI = new System.Windows.Forms.DateTimePicker();
            this.l_FIYAT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t_TEL2 = new System.Windows.Forms.TextBox();
            this.lv_URUN_SEC = new System.Windows.Forms.ListView();
            this.lv_SECILEN_URUNLER = new System.Windows.Forms.ListView();
            this.b_EKLE = new System.Windows.Forms.Button();
            this.b_CIKART = new System.Windows.Forms.Button();
            this.t_ADET = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.b_YENILE = new System.Windows.Forms.Button();
            this.gb_MUSTERI_EKLE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MUSTERI)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_AD
            // 
            this.t_AD.Location = new System.Drawing.Point(142, 36);
            this.t_AD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_AD.MaxLength = 50;
            this.t_AD.Multiline = true;
            this.t_AD.Name = "t_AD";
            this.t_AD.Size = new System.Drawing.Size(159, 30);
            this.t_AD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "ADI - SOYADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "TELEFON :";
            // 
            // t_ADRES
            // 
            this.t_ADRES.Location = new System.Drawing.Point(142, 154);
            this.t_ADRES.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_ADRES.Name = "t_ADRES";
            this.t_ADRES.Size = new System.Drawing.Size(159, 82);
            this.t_ADRES.TabIndex = 3;
            this.t_ADRES.Text = "";
            // 
            // t_TEL
            // 
            this.t_TEL.Location = new System.Drawing.Point(141, 74);
            this.t_TEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_TEL.MaxLength = 11;
            this.t_TEL.Multiline = true;
            this.t_TEL.Name = "t_TEL";
            this.t_TEL.Size = new System.Drawing.Size(159, 30);
            this.t_TEL.TabIndex = 1;
            this.t_TEL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TEL_KeyPress);
            // 
            // b_MUSTERI_EKLE
            // 
            this.b_MUSTERI_EKLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_MUSTERI_EKLE.BackColor = System.Drawing.Color.Brown;
            this.b_MUSTERI_EKLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_MUSTERI_EKLE.Location = new System.Drawing.Point(13, 638);
            this.b_MUSTERI_EKLE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_MUSTERI_EKLE.Name = "b_MUSTERI_EKLE";
            this.b_MUSTERI_EKLE.Size = new System.Drawing.Size(287, 37);
            this.b_MUSTERI_EKLE.TabIndex = 6;
            this.b_MUSTERI_EKLE.Text = "Müşteri Ekle";
            this.b_MUSTERI_EKLE.UseVisualStyleBackColor = false;
            this.b_MUSTERI_EKLE.Click += new System.EventHandler(this.button_musteriEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "ADRES :";
            // 
            // gb_MUSTERI_EKLE
            // 
            this.gb_MUSTERI_EKLE.BackColor = System.Drawing.Color.DarkCyan;
            this.gb_MUSTERI_EKLE.Controls.Add(this.dgv_MUSTERI);
            this.gb_MUSTERI_EKLE.Controls.Add(this.t_ARA);
            this.gb_MUSTERI_EKLE.Controls.Add(this.c_MUSTERI_KAYITLIYSA);
            this.gb_MUSTERI_EKLE.Controls.Add(this.c_ODEME_YAPILDIYSA);
            this.gb_MUSTERI_EKLE.Controls.Add(this.d_TESLIM_TARIHI);
            this.gb_MUSTERI_EKLE.Controls.Add(this.l_FIYAT);
            this.gb_MUSTERI_EKLE.Controls.Add(this.t_AD);
            this.gb_MUSTERI_EKLE.Controls.Add(this.label2);
            this.gb_MUSTERI_EKLE.Controls.Add(this.label4);
            this.gb_MUSTERI_EKLE.Controls.Add(this.label1);
            this.gb_MUSTERI_EKLE.Controls.Add(this.b_MUSTERI_EKLE);
            this.gb_MUSTERI_EKLE.Controls.Add(this.label6);
            this.gb_MUSTERI_EKLE.Controls.Add(this.label3);
            this.gb_MUSTERI_EKLE.Controls.Add(this.t_ADRES);
            this.gb_MUSTERI_EKLE.Controls.Add(this.t_TEL2);
            this.gb_MUSTERI_EKLE.Controls.Add(this.t_TEL);
            this.gb_MUSTERI_EKLE.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb_MUSTERI_EKLE.Enabled = false;
            this.gb_MUSTERI_EKLE.ForeColor = System.Drawing.Color.White;
            this.gb_MUSTERI_EKLE.Location = new System.Drawing.Point(685, 0);
            this.gb_MUSTERI_EKLE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_MUSTERI_EKLE.Name = "gb_MUSTERI_EKLE";
            this.gb_MUSTERI_EKLE.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_MUSTERI_EKLE.Size = new System.Drawing.Size(310, 733);
            this.gb_MUSTERI_EKLE.TabIndex = 31;
            this.gb_MUSTERI_EKLE.TabStop = false;
            this.gb_MUSTERI_EKLE.Text = "MÜŞTERİ EKLE";
            // 
            // dgv_MUSTERI
            // 
            this.dgv_MUSTERI.AllowUserToAddRows = false;
            this.dgv_MUSTERI.AllowUserToDeleteRows = false;
            this.dgv_MUSTERI.AllowUserToOrderColumns = true;
            this.dgv_MUSTERI.AllowUserToResizeColumns = false;
            this.dgv_MUSTERI.AllowUserToResizeRows = false;
            this.dgv_MUSTERI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_MUSTERI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MUSTERI.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_MUSTERI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_MUSTERI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MUSTERI.GridColor = System.Drawing.Color.Yellow;
            this.dgv_MUSTERI.Location = new System.Drawing.Point(9, 412);
            this.dgv_MUSTERI.MultiSelect = false;
            this.dgv_MUSTERI.Name = "dgv_MUSTERI";
            this.dgv_MUSTERI.ReadOnly = true;
            this.dgv_MUSTERI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_MUSTERI.RowHeadersVisible = false;
            this.dgv_MUSTERI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_MUSTERI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_MUSTERI.ShowCellErrors = false;
            this.dgv_MUSTERI.ShowCellToolTips = false;
            this.dgv_MUSTERI.ShowEditingIcon = false;
            this.dgv_MUSTERI.ShowRowErrors = false;
            this.dgv_MUSTERI.Size = new System.Drawing.Size(294, 218);
            this.dgv_MUSTERI.TabIndex = 34;
            this.dgv_MUSTERI.Visible = false;
            this.dgv_MUSTERI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_musteri_CellContentClick);
            // 
            // t_ARA
            // 
            this.t_ARA.Location = new System.Drawing.Point(7, 377);
            this.t_ARA.Name = "t_ARA";
            this.t_ARA.Size = new System.Drawing.Size(296, 29);
            this.t_ARA.TabIndex = 33;
            this.t_ARA.Text = "Müşterinin adına göre arayın.";
            this.t_ARA.Visible = false;
            this.t_ARA.Click += new System.EventHandler(this.textBox_m_ara_Click);
            this.t_ARA.TextChanged += new System.EventHandler(this.textBox_m_ara_TextChanged);
            // 
            // c_MUSTERI_KAYITLIYSA
            // 
            this.c_MUSTERI_KAYITLIYSA.AutoSize = true;
            this.c_MUSTERI_KAYITLIYSA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.c_MUSTERI_KAYITLIYSA.Location = new System.Drawing.Point(8, 315);
            this.c_MUSTERI_KAYITLIYSA.Name = "c_MUSTERI_KAYITLIYSA";
            this.c_MUSTERI_KAYITLIYSA.Size = new System.Drawing.Size(293, 25);
            this.c_MUSTERI_KAYITLIYSA.TabIndex = 5;
            this.c_MUSTERI_KAYITLIYSA.Text = "Müşteri önceden kayıtlıysa işaretleyin!";
            this.c_MUSTERI_KAYITLIYSA.UseVisualStyleBackColor = true;
            this.c_MUSTERI_KAYITLIYSA.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // c_ODEME_YAPILDIYSA
            // 
            this.c_ODEME_YAPILDIYSA.AutoSize = true;
            this.c_ODEME_YAPILDIYSA.Location = new System.Drawing.Point(9, 284);
            this.c_ODEME_YAPILDIYSA.Name = "c_ODEME_YAPILDIYSA";
            this.c_ODEME_YAPILDIYSA.Size = new System.Drawing.Size(285, 25);
            this.c_ODEME_YAPILDIYSA.TabIndex = 5;
            this.c_ODEME_YAPILDIYSA.Text = "Ödeme hemen yapıldıysa işaretleyin!";
            this.c_ODEME_YAPILDIYSA.UseVisualStyleBackColor = true;
            // 
            // d_TESLIM_TARIHI
            // 
            this.d_TESLIM_TARIHI.Location = new System.Drawing.Point(141, 249);
            this.d_TESLIM_TARIHI.Name = "d_TESLIM_TARIHI";
            this.d_TESLIM_TARIHI.Size = new System.Drawing.Size(159, 29);
            this.d_TESLIM_TARIHI.TabIndex = 4;
            // 
            // l_FIYAT
            // 
            this.l_FIYAT.AutoSize = true;
            this.l_FIYAT.Location = new System.Drawing.Point(138, 343);
            this.l_FIYAT.Name = "l_FIYAT";
            this.l_FIYAT.Size = new System.Drawing.Size(90, 21);
            this.l_FIYAT.TabIndex = 31;
            this.l_FIYAT.Text = "x tl alınacak";
            this.l_FIYAT.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "TESLİM TARIHI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "TELEFON(2):";
            // 
            // t_TEL2
            // 
            this.t_TEL2.Location = new System.Drawing.Point(142, 114);
            this.t_TEL2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_TEL2.MaxLength = 11;
            this.t_TEL2.Multiline = true;
            this.t_TEL2.Name = "t_TEL2";
            this.t_TEL2.Size = new System.Drawing.Size(159, 30);
            this.t_TEL2.TabIndex = 2;
            this.t_TEL2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TEL_KeyPress);
            // 
            // lv_URUN_SEC
            // 
            this.lv_URUN_SEC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_URUN_SEC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv_URUN_SEC.Location = new System.Drawing.Point(3, 35);
            this.lv_URUN_SEC.MultiSelect = false;
            this.lv_URUN_SEC.Name = "lv_URUN_SEC";
            this.lv_URUN_SEC.Size = new System.Drawing.Size(332, 701);
            this.lv_URUN_SEC.TabIndex = 32;
            this.lv_URUN_SEC.UseCompatibleStateImageBehavior = false;
            this.lv_URUN_SEC.SelectedIndexChanged += new System.EventHandler(this.listview_Urun_SelectedIndexChanged);
            // 
            // lv_SECILEN_URUNLER
            // 
            this.lv_SECILEN_URUNLER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_SECILEN_URUNLER.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lv_SECILEN_URUNLER.Location = new System.Drawing.Point(3, 35);
            this.lv_SECILEN_URUNLER.MultiSelect = false;
            this.lv_SECILEN_URUNLER.Name = "lv_SECILEN_URUNLER";
            this.lv_SECILEN_URUNLER.Size = new System.Drawing.Size(211, 698);
            this.lv_SECILEN_URUNLER.TabIndex = 32;
            this.lv_SECILEN_URUNLER.UseCompatibleStateImageBehavior = false;
            this.lv_SECILEN_URUNLER.SelectedIndexChanged += new System.EventHandler(this.lv_SECILEN_URUNLER_SelectedIndexChanged);
            // 
            // b_EKLE
            // 
            this.b_EKLE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.b_EKLE.BackColor = System.Drawing.Color.Brown;
            this.b_EKLE.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.b_EKLE.Location = new System.Drawing.Point(358, 197);
            this.b_EKLE.Name = "b_EKLE";
            this.b_EKLE.Size = new System.Drawing.Size(95, 69);
            this.b_EKLE.TabIndex = 33;
            this.b_EKLE.Text = "--> Ekle";
            this.b_EKLE.UseVisualStyleBackColor = false;
            this.b_EKLE.Click += new System.EventHandler(this.b_EKLE_Click);
            // 
            // b_CIKART
            // 
            this.b_CIKART.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.b_CIKART.BackColor = System.Drawing.Color.Brown;
            this.b_CIKART.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.b_CIKART.Location = new System.Drawing.Point(359, 337);
            this.b_CIKART.Name = "b_CIKART";
            this.b_CIKART.Size = new System.Drawing.Size(95, 69);
            this.b_CIKART.TabIndex = 34;
            this.b_CIKART.Text = "<-- Çıkart";
            this.b_CIKART.UseVisualStyleBackColor = false;
            this.b_CIKART.Visible = false;
            this.b_CIKART.Click += new System.EventHandler(this.button2_Click);
            // 
            // t_ADET
            // 
            this.t_ADET.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.t_ADET.Location = new System.Drawing.Point(358, 293);
            this.t_ADET.Name = "t_ADET";
            this.t_ADET.Size = new System.Drawing.Size(94, 29);
            this.t_ADET.TabIndex = 35;
            this.t_ADET.Text = "1";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Adet giriniz :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lv_URUN_SEC);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 739);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün seçiniz.";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lv_SECILEN_URUNLER);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(469, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 736);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seçilen ürünler.";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 42);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ürün seçip\r\nekleyiniz.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_YENILE
            // 
            this.b_YENILE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.b_YENILE.BackColor = System.Drawing.Color.Brown;
            this.b_YENILE.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.b_YENILE.Location = new System.Drawing.Point(359, 412);
            this.b_YENILE.Name = "b_YENILE";
            this.b_YENILE.Size = new System.Drawing.Size(93, 89);
            this.b_YENILE.TabIndex = 33;
            this.b_YENILE.Text = "Ürün Listesini Yenile";
            this.b_YENILE.UseVisualStyleBackColor = false;
            this.b_YENILE.Click += new System.EventHandler(this.b_YENILE_Click);
            // 
            // yenimusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(995, 733);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_ADET);
            this.Controls.Add(this.b_CIKART);
            this.Controls.Add(this.b_YENILE);
            this.Controls.Add(this.b_EKLE);
            this.Controls.Add(this.gb_MUSTERI_EKLE);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "yenimusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRY AKTAŞ Kuru Temizleme Müşteri Ekle ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.musteriler_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.musteriler_FormClosed);
            this.Load += new System.EventHandler(this.musteriler_Load);
            this.gb_MUSTERI_EKLE.ResumeLayout(false);
            this.gb_MUSTERI_EKLE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MUSTERI)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_AD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox t_ADRES;
        private System.Windows.Forms.TextBox t_TEL;
        private System.Windows.Forms.Button b_MUSTERI_EKLE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_MUSTERI_EKLE;
        public System.Windows.Forms.ListView lv_URUN_SEC;
        public System.Windows.Forms.ListView lv_SECILEN_URUNLER;
        public System.Windows.Forms.Label l_FIYAT;
        public System.Windows.Forms.Button b_EKLE;
        public System.Windows.Forms.Button b_CIKART;
        private System.Windows.Forms.TextBox t_ADET;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_TEL2;
        private System.Windows.Forms.DateTimePicker d_TESLIM_TARIHI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox c_ODEME_YAPILDIYSA;
        private System.Windows.Forms.CheckBox c_MUSTERI_KAYITLIYSA;
        private System.Windows.Forms.TextBox t_ARA;
        public System.Windows.Forms.DataGridView dgv_MUSTERI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button b_YENILE;
    }
}