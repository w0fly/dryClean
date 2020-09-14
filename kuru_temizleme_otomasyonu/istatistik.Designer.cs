namespace kuru_temizleme_otomasyonu
{
    partial class istatistik
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_KAZANC = new System.Windows.Forms.DataGridView();
            this.l_BUGUN = new System.Windows.Forms.Label();
            this.l_DUN = new System.Windows.Forms.Label();
            this.l_SON1YIL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KAZANC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_KAZANC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "En yüksek ödeme yapan müşteriler";
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_KAZANC.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_KAZANC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_KAZANC.Size = new System.Drawing.Size(330, 423);
            this.dgv_KAZANC.TabIndex = 17;
            // 
            // l_BUGUN
            // 
            this.l_BUGUN.AutoSize = true;
            this.l_BUGUN.Location = new System.Drawing.Point(355, 122);
            this.l_BUGUN.Name = "l_BUGUN";
            this.l_BUGUN.Size = new System.Drawing.Size(125, 21);
            this.l_BUGUN.TabIndex = 1;
            this.l_BUGUN.Text = "Bugün Kazanılan";
            // 
            // l_DUN
            // 
            this.l_DUN.AutoSize = true;
            this.l_DUN.Location = new System.Drawing.Point(355, 177);
            this.l_DUN.Name = "l_DUN";
            this.l_DUN.Size = new System.Drawing.Size(109, 21);
            this.l_DUN.TabIndex = 1;
            this.l_DUN.Text = "Dün Kazanılan";
            // 
            // l_SON1YIL
            // 
            this.l_SON1YIL.AutoSize = true;
            this.l_SON1YIL.Location = new System.Drawing.Point(359, 244);
            this.l_SON1YIL.Name = "l_SON1YIL";
            this.l_SON1YIL.Size = new System.Drawing.Size(60, 21);
            this.l_SON1YIL.TabIndex = 1;
            this.l_SON1YIL.Text = "Toplam";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(359, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(555, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_SON1YIL);
            this.Controls.Add(this.l_DUN);
            this.Controls.Add(this.l_BUGUN);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "istatistik";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRY AKTAŞ Kuru Temizleme İstatistik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.istatistik_FormClosing);
            this.Load += new System.EventHandler(this.istatistik_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KAZANC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgv_KAZANC;
        private System.Windows.Forms.Label l_BUGUN;
        private System.Windows.Forms.Label l_DUN;
        private System.Windows.Forms.Label l_SON1YIL;
        private System.Windows.Forms.Button button1;
    }
}