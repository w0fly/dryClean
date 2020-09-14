namespace kuru_temizleme_otomasyonu
{
    partial class urunler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.b_RESIM_EKLE = new System.Windows.Forms.Button();
            this.t_URUN_ADI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_URUN_FIYATI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_YENILE = new System.Windows.Forms.Button();
            this.b_URUNU_SIL = new System.Windows.Forms.Button();
            this.b_URUN_DUZENLE = new System.Windows.Forms.Button();
            this.b_URUN_EKLE = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_URUNLER = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_URUNLER)).BeginInit();
            this.SuspendLayout();
            // 
            // b_RESIM_EKLE
            // 
            this.b_RESIM_EKLE.BackColor = System.Drawing.Color.Brown;
            this.b_RESIM_EKLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_RESIM_EKLE.ForeColor = System.Drawing.Color.White;
            this.b_RESIM_EKLE.Location = new System.Drawing.Point(118, 111);
            this.b_RESIM_EKLE.Name = "b_RESIM_EKLE";
            this.b_RESIM_EKLE.Size = new System.Drawing.Size(124, 80);
            this.b_RESIM_EKLE.TabIndex = 0;
            this.b_RESIM_EKLE.Text = "Ürüne resim ekle";
            this.b_RESIM_EKLE.UseVisualStyleBackColor = false;
            this.b_RESIM_EKLE.Click += new System.EventHandler(this.b_RESIM_EKLE_Click);
            // 
            // t_URUN_ADI
            // 
            this.t_URUN_ADI.Location = new System.Drawing.Point(131, 33);
            this.t_URUN_ADI.Name = "t_URUN_ADI";
            this.t_URUN_ADI.Size = new System.Drawing.Size(197, 29);
            this.t_URUN_ADI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün ismi :  ";
            // 
            // t_URUN_FIYATI
            // 
            this.t_URUN_FIYATI.Location = new System.Drawing.Point(131, 76);
            this.t_URUN_FIYATI.Name = "t_URUN_FIYATI";
            this.t_URUN_FIYATI.Size = new System.Drawing.Size(197, 29);
            this.t_URUN_FIYATI.TabIndex = 1;
            this.t_URUN_FIYATI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_URUN_FIYATI_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün fiyatı (TL):  ";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(248, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_YENILE);
            this.groupBox1.Controls.Add(this.b_URUNU_SIL);
            this.groupBox1.Controls.Add(this.b_URUN_DUZENLE);
            this.groupBox1.Controls.Add(this.b_URUN_EKLE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.b_RESIM_EKLE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.t_URUN_ADI);
            this.groupBox1.Controls.Add(this.t_URUN_FIYATI);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 326);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün ekle";
            // 
            // b_YENILE
            // 
            this.b_YENILE.BackColor = System.Drawing.Color.Brown;
            this.b_YENILE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_YENILE.ForeColor = System.Drawing.Color.White;
            this.b_YENILE.Location = new System.Drawing.Point(6, 197);
            this.b_YENILE.Name = "b_YENILE";
            this.b_YENILE.Size = new System.Drawing.Size(106, 117);
            this.b_YENILE.TabIndex = 4;
            this.b_YENILE.Text = "Temizle";
            this.b_YENILE.UseVisualStyleBackColor = false;
            this.b_YENILE.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_URUNU_SIL
            // 
            this.b_URUNU_SIL.BackColor = System.Drawing.Color.Brown;
            this.b_URUNU_SIL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_URUNU_SIL.ForeColor = System.Drawing.Color.White;
            this.b_URUNU_SIL.Location = new System.Drawing.Point(118, 279);
            this.b_URUNU_SIL.Name = "b_URUNU_SIL";
            this.b_URUNU_SIL.Size = new System.Drawing.Size(210, 35);
            this.b_URUNU_SIL.TabIndex = 4;
            this.b_URUNU_SIL.Text = "Ürünü sil";
            this.b_URUNU_SIL.UseVisualStyleBackColor = false;
            this.b_URUNU_SIL.Visible = false;
            this.b_URUNU_SIL.Click += new System.EventHandler(this.b_URUNU_SIL_Click);
            // 
            // b_URUN_DUZENLE
            // 
            this.b_URUN_DUZENLE.BackColor = System.Drawing.Color.Brown;
            this.b_URUN_DUZENLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_URUN_DUZENLE.ForeColor = System.Drawing.Color.White;
            this.b_URUN_DUZENLE.Location = new System.Drawing.Point(118, 238);
            this.b_URUN_DUZENLE.Name = "b_URUN_DUZENLE";
            this.b_URUN_DUZENLE.Size = new System.Drawing.Size(210, 35);
            this.b_URUN_DUZENLE.TabIndex = 4;
            this.b_URUN_DUZENLE.Text = "Ürünü düzenle";
            this.b_URUN_DUZENLE.UseVisualStyleBackColor = false;
            this.b_URUN_DUZENLE.Visible = false;
            this.b_URUN_DUZENLE.Click += new System.EventHandler(this.b_URUN_DUZENLE_Click);
            // 
            // b_URUN_EKLE
            // 
            this.b_URUN_EKLE.BackColor = System.Drawing.Color.Brown;
            this.b_URUN_EKLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_URUN_EKLE.ForeColor = System.Drawing.Color.White;
            this.b_URUN_EKLE.Location = new System.Drawing.Point(118, 197);
            this.b_URUN_EKLE.Name = "b_URUN_EKLE";
            this.b_URUN_EKLE.Size = new System.Drawing.Size(210, 35);
            this.b_URUN_EKLE.TabIndex = 4;
            this.b_URUN_EKLE.Text = "Ürünü ekle";
            this.b_URUN_EKLE.UseVisualStyleBackColor = false;
            this.b_URUN_EKLE.Visible = false;
            this.b_URUN_EKLE.Click += new System.EventHandler(this.b_URUN_EKLE_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_URUNLER);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(365, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 326);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün listesi - Ürün seçiniz.";
            // 
            // dgv_URUNLER
            // 
            this.dgv_URUNLER.AllowUserToAddRows = false;
            this.dgv_URUNLER.AllowUserToDeleteRows = false;
            this.dgv_URUNLER.AllowUserToOrderColumns = true;
            this.dgv_URUNLER.AllowUserToResizeColumns = false;
            this.dgv_URUNLER.AllowUserToResizeRows = false;
            this.dgv_URUNLER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_URUNLER.BackgroundColor = System.Drawing.Color.White;
            this.dgv_URUNLER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_URUNLER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_URUNLER.GridColor = System.Drawing.Color.Black;
            this.dgv_URUNLER.Location = new System.Drawing.Point(3, 25);
            this.dgv_URUNLER.MultiSelect = false;
            this.dgv_URUNLER.Name = "dgv_URUNLER";
            this.dgv_URUNLER.ReadOnly = true;
            this.dgv_URUNLER.RowHeadersVisible = false;
            this.dgv_URUNLER.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_URUNLER.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_URUNLER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_URUNLER.Size = new System.Drawing.Size(469, 298);
            this.dgv_URUNLER.TabIndex = 16;
            this.dgv_URUNLER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_URUNLER_CellContentClick);
            // 
            // urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(852, 346);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "urunler";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRY AKTAŞ Kuru Temizleme Ürünler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.urunler_FormClosing);
            this.Load += new System.EventHandler(this.urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_URUNLER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_RESIM_EKLE;
        private System.Windows.Forms.TextBox t_URUN_ADI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_URUN_FIYATI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_URUN_EKLE;
        private System.Windows.Forms.Button b_URUNU_SIL;
        private System.Windows.Forms.Button b_URUN_DUZENLE;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgv_URUNLER;
        private System.Windows.Forms.Button b_YENILE;
    }
}