namespace kuru_temizleme_otomasyonu
{
    partial class Form_Giris
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
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_giris = new System.Windows.Forms.Button();
            this.label_firmaAdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kadi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(186, 149);
            this.textBox_sifre.MaxLength = 12;
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(198, 29);
            this.textBox_sifre.TabIndex = 1;
            this.textBox_sifre.Click += new System.EventHandler(this.textBox_Click);
            this.textBox_sifre.TextChanged += new System.EventHandler(this.textBox_sifre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şifre giriniz :";
            // 
            // button_giris
            // 
            this.button_giris.BackColor = System.Drawing.Color.Brown;
            this.button_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_giris.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_giris.Location = new System.Drawing.Point(186, 184);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(198, 42);
            this.button_giris.TabIndex = 2;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseVisualStyleBackColor = false;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // label_firmaAdi
            // 
            this.label_firmaAdi.AutoSize = true;
            this.label_firmaAdi.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_firmaAdi.Location = new System.Drawing.Point(67, 40);
            this.label_firmaAdi.Name = "label_firmaAdi";
            this.label_firmaAdi.Size = new System.Drawing.Size(372, 37);
            this.label_firmaAdi.TabIndex = 3;
            this.label_firmaAdi.Text = "DRY AKTAŞ KURU TEMİZLEME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı adı :";
            // 
            // textBox_kadi
            // 
            this.textBox_kadi.Location = new System.Drawing.Point(187, 109);
            this.textBox_kadi.MaxLength = 12;
            this.textBox_kadi.Name = "textBox_kadi";
            this.textBox_kadi.Size = new System.Drawing.Size(197, 29);
            this.textBox_kadi.TabIndex = 0;
            this.textBox_kadi.Click += new System.EventHandler(this.textBox_Click);
            // 
            // Form_Giris
            // 
            this.AcceptButton = this.button_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(514, 268);
            this.Controls.Add(this.textBox_kadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_firmaAdi);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sifre);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Giris";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuru Temizleme Takip Programı v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Giris_FormClosing);
            this.Load += new System.EventHandler(this.Form_Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Label label_firmaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kadi;

    }
}

