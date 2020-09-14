using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuru_temizleme_otomasyonu
{
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
        }
        private void Form_Giris_Load(object sender, EventArgs e)
        {
            veritabani.kullaniciBilgisi = veritabani.veriGetir("select * from KULLANICILAR");
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            t.Clear();
        }

        private void textBox_sifre_TextChanged(object sender, EventArgs e)
        {
            textBox_sifre.PasswordChar = '*';
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < veritabani.kullaniciBilgisi.Rows.Count; i++)
			{
                if (veritabani.kullaniciBilgisi.Rows[i]["SIFRE"].ToString() == textBox_sifre.Text && veritabani.kullaniciBilgisi.Rows[i]["KULLANICI_ADI"].ToString() == textBox_kadi.Text)
                {
                    formlar.FRMmenu.l_KADI.Text = "Hoşgeldiniz : "+ veritabani.kullaniciBilgisi.Rows[i]["KULLANICI_ADI"].ToString();
                    veritabani.rutbe = veritabani.kullaniciBilgisi.Rows[i]["RUTBE"].ToString();
                    veritabani.kullaniciadi = veritabani.kullaniciBilgisi.Rows[i]["KULLANICI_ADI"].ToString();
                    if (veritabani.kullaniciBilgisi.Rows[i]["RUTBE"].ToString() == "Patron")
                        formlar.FRMmenu.p_K.Visible = formlar.FRMmenu.label1.Visible = formlar.FRMmenu.p_A.Visible = formlar.FRMmenu.label2.Visible = formlar.FRMmenu.label3.Visible = formlar.FRMmenu.label4.Visible = formlar.FRMmenu.p_I.Visible = formlar.FRMmenu.p_U.Visible = true;
                    veritabani.guncelleEkle("INSERT INTO LOG(LOG_K,LOG_T) values('" + veritabani.kullaniciBilgisi.Rows[i]["KULLANICI_ADI"].ToString() + "','" + DateTime.Now.ToString() + "')"); // Giren kullanıcı kaydı
                    formlar.FRMdashboard.Show();
                    textBox_kadi.Text = textBox_sifre.Text = "";
                    this.Hide();
                    break;
                }
                else if (i == veritabani.kullaniciBilgisi.Rows.Count - 1) MessageBox.Show("Hatalı giriş yaptınız!");
            }
        }

        private void Form_Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
