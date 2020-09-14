namespace kuru_temizleme_otomasyonu
{
    partial class kullanicilar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_ksil = new System.Windows.Forms.Button();
            this.button_kduzenle = new System.Windows.Forms.Button();
            this.button_kekle = new System.Windows.Forms.Button();
            this.comboBox_rutbe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_eposta = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kadi = new System.Windows.Forms.TextBox();
            this.dgv_KULLANICILAR = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KULLANICILAR)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_temizle);
            this.groupBox1.Controls.Add(this.button_ksil);
            this.groupBox1.Controls.Add(this.button_kduzenle);
            this.groupBox1.Controls.Add(this.button_kekle);
            this.groupBox1.Controls.Add(this.comboBox_rutbe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_eposta);
            this.groupBox1.Controls.Add(this.textBox_tel);
            this.groupBox1.Controls.Add(this.textBox_sifre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_kadi);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 376);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı ekle - düzenle - sil";
            // 
            // button_temizle
            // 
            this.button_temizle.BackColor = System.Drawing.Color.Brown;
            this.button_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_temizle.ForeColor = System.Drawing.Color.White;
            this.button_temizle.Location = new System.Drawing.Point(29, 224);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(157, 143);
            this.button_temizle.TabIndex = 8;
            this.button_temizle.Text = "Temizle";
            this.button_temizle.UseVisualStyleBackColor = false;
            this.button_temizle.Visible = false;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // button_ksil
            // 
            this.button_ksil.BackColor = System.Drawing.Color.Brown;
            this.button_ksil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ksil.ForeColor = System.Drawing.Color.White;
            this.button_ksil.Location = new System.Drawing.Point(193, 327);
            this.button_ksil.Name = "button_ksil";
            this.button_ksil.Size = new System.Drawing.Size(157, 40);
            this.button_ksil.TabIndex = 7;
            this.button_ksil.Text = "Kullanıcıyı sil";
            this.button_ksil.UseVisualStyleBackColor = false;
            this.button_ksil.Visible = false;
            this.button_ksil.Click += new System.EventHandler(this.button_ksil_Click);
            // 
            // button_kduzenle
            // 
            this.button_kduzenle.BackColor = System.Drawing.Color.Brown;
            this.button_kduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kduzenle.ForeColor = System.Drawing.Color.White;
            this.button_kduzenle.Location = new System.Drawing.Point(193, 278);
            this.button_kduzenle.Name = "button_kduzenle";
            this.button_kduzenle.Size = new System.Drawing.Size(157, 43);
            this.button_kduzenle.TabIndex = 6;
            this.button_kduzenle.Text = "Kullanıcıyı düzenle";
            this.button_kduzenle.UseVisualStyleBackColor = false;
            this.button_kduzenle.Visible = false;
            this.button_kduzenle.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_kekle
            // 
            this.button_kekle.BackColor = System.Drawing.Color.Brown;
            this.button_kekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kekle.ForeColor = System.Drawing.Color.White;
            this.button_kekle.Location = new System.Drawing.Point(194, 224);
            this.button_kekle.Name = "button_kekle";
            this.button_kekle.Size = new System.Drawing.Size(157, 48);
            this.button_kekle.TabIndex = 5;
            this.button_kekle.Text = "Kullanıcıyı ekle";
            this.button_kekle.UseVisualStyleBackColor = false;
            this.button_kekle.Visible = false;
            this.button_kekle.Click += new System.EventHandler(this.button_kekle_Click);
            // 
            // comboBox_rutbe
            // 
            this.comboBox_rutbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rutbe.FormattingEnabled = true;
            this.comboBox_rutbe.Items.AddRange(new object[] {
            "Üye",
            "Patron"});
            this.comboBox_rutbe.Location = new System.Drawing.Point(134, 189);
            this.comboBox_rutbe.Name = "comboBox_rutbe";
            this.comboBox_rutbe.Size = new System.Drawing.Size(216, 29);
            this.comboBox_rutbe.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "RÜTBE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-POSTA :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(69, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "ŞİFRE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "TELEFON :";
            // 
            // textBox_eposta
            // 
            this.textBox_eposta.Location = new System.Drawing.Point(134, 147);
            this.textBox_eposta.MaxLength = 255;
            this.textBox_eposta.Name = "textBox_eposta";
            this.textBox_eposta.Size = new System.Drawing.Size(216, 29);
            this.textBox_eposta.TabIndex = 3;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(134, 112);
            this.textBox_tel.MaxLength = 11;
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(216, 29);
            this.textBox_tel.TabIndex = 2;
            this.textBox_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_tel_KeyPress);
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(133, 77);
            this.textBox_sifre.MaxLength = 12;
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(216, 29);
            this.textBox_sifre.TabIndex = 1;
            this.textBox_sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_sifre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "KULLANICI ADI :";
            // 
            // textBox_kadi
            // 
            this.textBox_kadi.Location = new System.Drawing.Point(134, 42);
            this.textBox_kadi.MaxLength = 12;
            this.textBox_kadi.Name = "textBox_kadi";
            this.textBox_kadi.Size = new System.Drawing.Size(216, 29);
            this.textBox_kadi.TabIndex = 0;
            // 
            // dgv_KULLANICILAR
            // 
            this.dgv_KULLANICILAR.AllowUserToAddRows = false;
            this.dgv_KULLANICILAR.AllowUserToDeleteRows = false;
            this.dgv_KULLANICILAR.AllowUserToOrderColumns = true;
            this.dgv_KULLANICILAR.AllowUserToResizeColumns = false;
            this.dgv_KULLANICILAR.AllowUserToResizeRows = false;
            this.dgv_KULLANICILAR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KULLANICILAR.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_KULLANICILAR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KULLANICILAR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_KULLANICILAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KULLANICILAR.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_KULLANICILAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KULLANICILAR.GridColor = System.Drawing.Color.Yellow;
            this.dgv_KULLANICILAR.Location = new System.Drawing.Point(3, 25);
            this.dgv_KULLANICILAR.MultiSelect = false;
            this.dgv_KULLANICILAR.Name = "dgv_KULLANICILAR";
            this.dgv_KULLANICILAR.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KULLANICILAR.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_KULLANICILAR.RowHeadersVisible = false;
            this.dgv_KULLANICILAR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_KULLANICILAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_KULLANICILAR.Size = new System.Drawing.Size(467, 351);
            this.dgv_KULLANICILAR.TabIndex = 16;
            this.dgv_KULLANICILAR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_KULLANICILAR);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(379, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 379);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcılar listesi";
            // 
            // kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(853, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kullanicilar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRY AKTAŞ Kuru Temizleme Kullanıcılar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kullanicilar_FormClosing);
            this.Load += new System.EventHandler(this.kullanicilar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KULLANICILAR)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_kduzenle;
        private System.Windows.Forms.Button button_kekle;
        private System.Windows.Forms.ComboBox comboBox_rutbe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_eposta;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kadi;
        private System.Windows.Forms.Button button_ksil;
        public System.Windows.Forms.DataGridView dgv_KULLANICILAR;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}