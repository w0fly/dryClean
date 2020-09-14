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
    public partial class musteris : Form
    {
        public musteris()
        {
            InitializeComponent();
        }


        void yenile()
        {
            DataTable musteriler = veritabani.veriGetir("select * from MUSTERILER");
            dgv_KULLANICILAR.DataSource = musteriler;
            button_kduzenle.Visible = button_ksil.Visible = false;
            button_kekle.Enabled = true;
            t_AD.Text = t_TEL.Text = t_ADRES.Text = t_TEL2.Text = "";
        }

        private void musteris_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void musteris_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        void txtboxTemizle()
        {
            t_AD.Text = t_TEL.Text = t_ADRES.Text = t_TEL2.Text = "";
        }
        string m_id;
        private void dgv_KULLANICILAR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            m_id = dgv_KULLANICILAR.CurrentRow.Cells["M_ID"].Value.ToString();
            if (dgv_KULLANICILAR.CurrentCell.Selected == true || dgv_KULLANICILAR.CurrentRow.Selected == true) // Herhangi bir sütuna tıklandıysa
            {
                t_AD.Text = dgv_KULLANICILAR.CurrentRow.Cells["M_ADI_SOYADI"].Value.ToString();
                t_TEL.Text = dgv_KULLANICILAR.CurrentRow.Cells["M_TEL"].Value.ToString();
                t_TEL2.Text = dgv_KULLANICILAR.CurrentRow.Cells["M_TEL2"].Value.ToString();
                t_ADRES.Text = dgv_KULLANICILAR.CurrentRow.Cells["M_ADRES"].Value.ToString();
                button_kekle.Enabled = false;
                if (veritabani.rutbe == "Patron")
                    button_kduzenle.Visible =  button_ksil.Visible = true;
                else
                    button_kduzenle.Visible = button_ksil.Visible = false;
                
            }
        }

        private void button_kekle_Click(object sender, EventArgs e)
        {
            if (t_AD.Text != "")
            {
                try
                {
                    veritabani.guncelleEkle("insert into MUSTERILER(M_ADI_SOYADI,M_TEL,M_TEL2,M_ADRES) values('" + t_AD.Text + "','" + t_TEL.Text + "','" + t_TEL2.Text + "','" + t_ADRES.Text + "')");
                    MessageBox.Show("Kullanıcı başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilinmeyen bir veri tabanı hatası oluştu.\nHatanın kaynağı aşağıda belirtilmiştir.\n\n" + ex.ToString());
                }
                yenile();
                txtboxTemizle();
            }
            else
            {
                MessageBox.Show("isim boş bırakılamaz!");
            }
        }

        private void button_kduzenle_Click(object sender, EventArgs e)
        {
            if (t_AD.Text != "")
            {
                try
                {
                    veritabani.guncelleEkle("update MUSTERILER set M_ADI_SOYADI='" + t_AD.Text + "', M_TEL='" + t_TEL.Text + "',M_TEL2='" + t_TEL2.Text + "',M_ADRES='" + t_ADRES.Text + "' where M_ID=" + m_id);
                    MessageBox.Show("Kullanıcı başarıyla düzenlendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilinmeyen bir veri tabanı hatası oluştu.\nHatanın kaynağı aşağıda belirtilmiştir.\n\n" + ex.ToString());
                }
                yenile();
                txtboxTemizle();
            }
            else
            {
                MessageBox.Show("isim boş bırakılamaz!");
            }
        }

        private void button_ksil_Click(object sender, EventArgs e)
        {
            if (t_AD.Text != "")
            {
                DialogResult cevap = MessageBox.Show("Kullanıcıyı silmek istiyor musunuz ?", "Kullanıcı siliniyor!", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        veritabani.guncelleEkle("DELETE FROM MUSTERILER where M_ID=" + m_id);
                        MessageBox.Show("Müşteri başarıyla silindi.");
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Bu müşteriyi silemezsiniz.\nÇünkü müşteri bize kazanç sağlamıştır.\nEğer müşteriyi silmek isterseniz program yapımcısına başvurun!");
                    }
                }
            }
            else
            {
                MessageBox.Show("isim boş bırakılamaz!");
            }
            yenile();
            txtboxTemizle();
        }

        private void t_TEL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08) e.Handled = true;
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void t_ARA_TextChanged(object sender, EventArgs e)
        {
            if (t_ARA.Text == "") yenile();
            else
            {
               try
                {
                    // Arama yapıldığında aranan kelimeyi fiş numarasıyla sorgula
                    DataTable aranan = veritabani.veriGetir("Select * from MUSTERILER where(M_ADI_SOYADI like '%" + t_ARA.Text + "%')");
                    dgv_KULLANICILAR.DataSource = aranan;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilinmeyen veri tabanı hatası oluştur.Hatanın nedeni aşağıda belirtilmiştir.\n\n" + ex.ToString());
                }
            }
        }

        private void t_ARA_Click(object sender, EventArgs e)
        {
            t_ARA.Text = "";
        }
    }
}
