namespace kuru_temizleme_otomasyonu
{
    partial class musteris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_ARA = new System.Windows.Forms.TextBox();
            this.dgv_KULLANICILAR = new System.Windows.Forms.DataGridView();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_ksil = new System.Windows.Forms.Button();
            this.button_kduzenle = new System.Windows.Forms.Button();
            this.button_kekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t_AD = new System.Windows.Forms.TextBox();
            this.t_ADRES = new System.Windows.Forms.RichTextBox();
            this.t_TEL2 = new System.Windows.Forms.TextBox();
            this.t_TEL = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KULLANICILAR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.t_ARA);
            this.groupBox2.Controls.Add(this.dgv_KULLANICILAR);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(379, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 379);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteriler listesi";
            // 
            // t_ARA
            // 
            this.t_ARA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_ARA.Location = new System.Drawing.Point(6, 26);
            this.t_ARA.MaxLength = 15;
            this.t_ARA.Name = "t_ARA";
            this.t_ARA.Size = new System.Drawing.Size(461, 29);
            this.t_ARA.TabIndex = 19;
            this.t_ARA.Text = "Müşteri adı ile arama yapınız.";
            this.t_ARA.Click += new System.EventHandler(this.t_ARA_Click);
            this.t_ARA.TextChanged += new System.EventHandler(this.t_ARA_TextChanged);
            // 
            // dgv_KULLANICILAR
            // 
            this.dgv_KULLANICILAR.AllowUserToAddRows = false;
            this.dgv_KULLANICILAR.AllowUserToDeleteRows = false;
            this.dgv_KULLANICILAR.AllowUserToOrderColumns = true;
            this.dgv_KULLANICILAR.AllowUserToResizeColumns = false;
            this.dgv_KULLANICILAR.AllowUserToResizeRows = false;
            this.dgv_KULLANICILAR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_KULLANICILAR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KULLANICILAR.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_KULLANICILAR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_KULLANICILAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KULLANICILAR.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_KULLANICILAR.GridColor = System.Drawing.Color.Yellow;
            this.dgv_KULLANICILAR.Location = new System.Drawing.Point(3, 63);
            this.dgv_KULLANICILAR.MultiSelect = false;
            this.dgv_KULLANICILAR.Name = "dgv_KULLANICILAR";
            this.dgv_KULLANICILAR.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KULLANICILAR.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_KULLANICILAR.RowHeadersVisible = false;
            this.dgv_KULLANICILAR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_KULLANICILAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_KULLANICILAR.Size = new System.Drawing.Size(467, 313);
            this.dgv_KULLANICILAR.TabIndex = 16;
            this.dgv_KULLANICILAR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KULLANICILAR_CellContentClick);
            // 
            // button_temizle
            // 
            this.button_temizle.BackColor = System.Drawing.Color.Brown;
            this.button_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_temizle.ForeColor = System.Drawing.Color.White;
            this.button_temizle.Location = new System.Drawing.Point(6, 224);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(116, 143);
            this.button_temizle.TabIndex = 8;
            this.button_temizle.Text = "Temizle";
            this.button_temizle.UseVisualStyleBackColor = false;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // button_ksil
            // 
            this.button_ksil.AutoSize = true;
            this.button_ksil.BackColor = System.Drawing.Color.Brown;
            this.button_ksil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ksil.ForeColor = System.Drawing.Color.White;
            this.button_ksil.Location = new System.Drawing.Point(129, 327);
            this.button_ksil.Name = "button_ksil";
            this.button_ksil.Size = new System.Drawing.Size(221, 40);
            this.button_ksil.TabIndex = 7;
            this.button_ksil.Text = "Müşteri sil";
            this.button_ksil.UseVisualStyleBackColor = false;
            this.button_ksil.Click += new System.EventHandler(this.button_ksil_Click);
            // 
            // button_kduzenle
            // 
            this.button_kduzenle.BackColor = System.Drawing.Color.Brown;
            this.button_kduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kduzenle.ForeColor = System.Drawing.Color.White;
            this.button_kduzenle.Location = new System.Drawing.Point(128, 278);
            this.button_kduzenle.Name = "button_kduzenle";
            this.button_kduzenle.Size = new System.Drawing.Size(222, 43);
            this.button_kduzenle.TabIndex = 6;
            this.button_kduzenle.Text = "Müşteri düzenle";
            this.button_kduzenle.UseVisualStyleBackColor = false;
            this.button_kduzenle.Click += new System.EventHandler(this.button_kduzenle_Click);
            // 
            // button_kekle
            // 
            this.button_kekle.BackColor = System.Drawing.Color.Brown;
            this.button_kekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kekle.ForeColor = System.Drawing.Color.White;
            this.button_kekle.Location = new System.Drawing.Point(129, 224);
            this.button_kekle.Name = "button_kekle";
            this.button_kekle.Size = new System.Drawing.Size(222, 48);
            this.button_kekle.TabIndex = 5;
            this.button_kekle.Text = "Müşteri ekle";
            this.button_kekle.UseVisualStyleBackColor = false;
            this.button_kekle.Click += new System.EventHandler(this.button_kekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "ADRES :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "TELEFON :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "TELEFON (2) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADI - SOYADI :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t_AD);
            this.groupBox1.Controls.Add(this.t_ADRES);
            this.groupBox1.Controls.Add(this.t_TEL2);
            this.groupBox1.Controls.Add(this.t_TEL);
            this.groupBox1.Controls.Add(this.button_temizle);
            this.groupBox1.Controls.Add(this.button_ksil);
            this.groupBox1.Controls.Add(this.button_kduzenle);
            this.groupBox1.Controls.Add(this.button_kekle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 376);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri ekle - düzenle - sil";
            // 
            // t_AD
            // 
            this.t_AD.Location = new System.Drawing.Point(129, 25);
            this.t_AD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_AD.MaxLength = 50;
            this.t_AD.Multiline = true;
            this.t_AD.Name = "t_AD";
            this.t_AD.Size = new System.Drawing.Size(209, 30);
            this.t_AD.TabIndex = 9;
            // 
            // t_ADRES
            // 
            this.t_ADRES.Location = new System.Drawing.Point(129, 143);
            this.t_ADRES.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_ADRES.Name = "t_ADRES";
            this.t_ADRES.Size = new System.Drawing.Size(209, 73);
            this.t_ADRES.TabIndex = 12;
            this.t_ADRES.Text = "";
            // 
            // t_TEL2
            // 
            this.t_TEL2.Location = new System.Drawing.Point(129, 103);
            this.t_TEL2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_TEL2.MaxLength = 11;
            this.t_TEL2.Multiline = true;
            this.t_TEL2.Name = "t_TEL2";
            this.t_TEL2.Size = new System.Drawing.Size(209, 30);
            this.t_TEL2.TabIndex = 11;
            this.t_TEL2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_TEL_KeyPress);
            // 
            // t_TEL
            // 
            this.t_TEL.Location = new System.Drawing.Point(129, 63);
            this.t_TEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_TEL.MaxLength = 11;
            this.t_TEL.Multiline = true;
            this.t_TEL.Name = "t_TEL";
            this.t_TEL.Size = new System.Drawing.Size(208, 30);
            this.t_TEL.TabIndex = 10;
            this.t_TEL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_TEL_KeyPress);
            // 
            // musteris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(860, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "musteris";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRY AKTAŞ Kuru Temizleme Müşteri Bilgileri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.musteris_FormClosing);
            this.Load += new System.EventHandler(this.musteris_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KULLANICILAR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgv_KULLANICILAR;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_ksil;
        private System.Windows.Forms.Button button_kduzenle;
        private System.Windows.Forms.Button button_kekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t_AD;
        private System.Windows.Forms.RichTextBox t_ADRES;
        private System.Windows.Forms.TextBox t_TEL2;
        private System.Windows.Forms.TextBox t_TEL;
        private System.Windows.Forms.TextBox t_ARA;


    }
}