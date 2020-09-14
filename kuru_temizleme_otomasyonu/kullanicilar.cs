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
    public partial class kullanicilar : Form
    {
        public kullanicilar()
        {
            InitializeComponent();
        }

        private void kullanicilar_FormClosing(object sender, FormClosingEventArgs e)
        {
            yenile();
            this.Hide();
            e.Cancel = true;
        }
        void yenile()
        {
            DataTable dt = veritabani.veriGetir("select * from KULLANICILAR");
            dgv_KULLANICILAR.DataSource = dt;
            button_kduzenle.Visible = button_ksil.Visible = false;
            button_kekle.Visible = button_kekle.Enabled = button_temizle.Visible = true;
            comboBox_rutbe.SelectedIndex = 0;
        }
        private void kullanicilar_Load(object sender, EventArgs e)
        {
            yenile();
            dgv_KULLANICILAR.ForeColor = Color.Black;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_KULLANICILAR.CurrentCell.Selected == true || dgv_KULLANICILAR.CurrentRow.Selected == true) // Herhangi bir sütuna tıklandıysa
            {
                textBox_kadi.Text = dgv_KULLANICILAR.CurrentRow.Cells["KULLANICI_ADI"].Value.ToString();
                textBox_sifre.Text = dgv_KULLANICILAR.CurrentRow.Cells["SIFRE"].Value.ToString();
                textBox_tel.Text = dgv_KULLANICILAR.CurrentRow.Cells["TEL"].Value.ToString();
                textBox_eposta.Text = dgv_KULLANICILAR.CurrentRow.Cells["EPOSTA"].Value.ToString();
                comboBox_rutbe.Text = dgv_KULLANICILAR.CurrentRow.Cells["RUTBE"].Value.ToString();
                textBox_kadi.Enabled = false;
                button_kekle.Enabled = false;
                button_kduzenle.Visible = true;
                button_ksil.Visible = true;
            }
        }
        void txtboxTemizle()
        {
            textBox_kadi.Text = textBox_sifre.Text = textBox_tel.Text = textBox_eposta.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_kadi.Text != "" && textBox_sifre.Text != "")
            {
                try
                {
                    veritabani.guncelleEkle("update KULLANICILAR set KULLANICI_ADI='" + textBox_kadi.Text + "', SIFRE='" + textBox_sifre.Text + "',TEL='" + textBox_tel.Text + "',EPOSTA='" + textBox_eposta.Text + "', RUTBE='"+comboBox_rutbe.Text+"' where KULLANICI_ADI='" + textBox_kadi.Text + "'");
                    MessageBox.Show("Kullanıcı başarıyla düzenlendi.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı adı mevcut başka bir isim deneyin!");
                }
                yenile();
                txtboxTemizle();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!");
            }
        }

        private void button_ksil_Click(object sender, EventArgs e)
        {
            if (textBox_kadi.Text != "" && textBox_sifre.Text != "")
            {
                DialogResult cevap = MessageBox.Show("Kullanıcıyı silmek istiyor musunuz ?", "Kullanıcı siliniyor!", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.Yes)
                {
                    veritabani.guncelleEkle("DELETE FROM KULLANICILAR where KULLANICI_ADI='" + textBox_kadi.Text + "'");
                    MessageBox.Show("Kullanıcı başarıyla silindi.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!");
            }
            yenile();
            txtboxTemizle();
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            txtboxTemizle();
            yenile();
            textBox_kadi.Enabled = true;
            button_kekle.Enabled = true;
        }

        private void button_kekle_Click(object sender, EventArgs e)
        {
            if (textBox_kadi.Text != "" && textBox_sifre.Text != "")
            {
                try
                {
                    veritabani.guncelleEkle("insert into KULLANICILAR(KULLANICI_ADI,SIFRE,TEL,EPOSTA,RUTBE) values('" + textBox_kadi.Text + "','" + textBox_sifre.Text + "','" + textBox_tel.Text + "','" + textBox_eposta.Text + "','" + comboBox_rutbe.Text + "')");
                    MessageBox.Show("Kullanıcı başarıyla eklendi.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı adı zaten mevcut!");
                }
                yenile();
                txtboxTemizle();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!");
            }
        }

        private void textBox_sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08) e.Handled = true;
        }
    }
}
