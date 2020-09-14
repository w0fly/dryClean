using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kuru_temizleme_otomasyonu
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        // SQL Sorgusuyla getirilen verilerimiz.
        string veri = "SELECT GETIRILEN.FIS_NO as Fiş_No, MUSTERILER.M_ADI_SOYADI as Ad_Soyad, GETIRILEN.T_TARIH as Teslim_Tarihi, GETIRILEN.G_URUNLER as Getirilen_Ürünler , GETIRILEN.A_TUTAR as Tutar, GETIRILEN.O_YAPILDIMI as Ödeme_Yapıldı_Mı,MUSTERILER.M_ID FROM (MUSTERILER INNER JOIN GETIRILEN ON MUSTERILER.M_ID = GETIRILEN.M_ID) ";
        DataTable gT; // Günün toplamı datatablemiz

        void yenile()
        {
            try
            {
                DataTable LOG = veritabani.veriGetir("Select LOG_K as Kullanıcı,LOG_T as Giriş_Saati From LOG ORDER BY LOG_T DESC"); // Kayıt LOG verileri
                DataTable aU = veritabani.veriGetir(veri + " where GETIRILEN.T_EDILDIMI=false ORDER BY GETIRILEN.T_TARIH ASC"); // Teslim edilmeyen ürünleri getir tarihe göre sırala
                DataTable tE = veritabani.veriGetir(veri + " where GETIRILEN.T_EDILDIMI=true ORDER BY GETIRILEN.T_TARIH ASC");// Teslim edilen ürünleri getir tarihe göre sırala
                DataTable kZ = veritabani.veriGetir("select MUSTERILER.M_ADI_SOYADI,KAZANC.K_MIKTAR,KAZANC.K_TARIH from KAZANC inner join MUSTERILER on MUSTERILER.M_ID = KAZANC.M_ID where(KAZANC.K_TARIH like '%" + DateTime.Now.Date.ToString().Replace(" 00:00:00", "") + "%')");
                gT = veritabani.veriGetir("Select SUM(K_MIKTAR) as K_MIKTAR From KAZANC where (K_TARIH like '%" + DateTime.Now.Date.ToString().Replace(" 00:00:00", "") + "%')");
                l_GUNUN_TOPLAMI.Text = gT.Rows[0]["K_MIKTAR"].ToString() + " ₺";
                dgv_TESLIM_EDILECEK.DataSource = aU; // Teslim edilecek verileri dataGridView de göster
                dgv_TESLIM_EDILEN.DataSource = tE; // Teslim edilen verileri dataGridView de göster
                dgv_KAZANC.DataSource = kZ; // Kazanc verilerini dataGridView de göster
                dgv_GIRIS.DataSource = LOG; // Giriş kayıt verilerini dataGridView de göster
                l_ODENECEK_TUTAR.Text = "";
                chart1.Series.Clear();
                chart1.Series.Add("Dün");
                chart1.Series.Add("Bugün");
                DateTime dt = DateTime.Today;
                int yil = dt.Year;
                int ay = dt.Month;
                int gun = dt.Day - 1;
                chart1.Series["Bugün"].Points.AddXY(DateTime.Now.ToString().Replace(" 00:00:00", ""), gT.Rows[0]["K_MIKTAR"].ToString());
                DataTable dununToplami = veritabani.veriGetir("Select SUM(K_MIKTAR) as K_MIKTAR From KAZANC where (K_TARIH like '%" + gun + "." + ay + "." + yil + "%')");
                chart1.Series["Dün"].Points.AddXY(gun + "." + ay + "." + yil, dununToplami.Rows[0]["K_MIKTAR"].ToString());
                b_IPTAL_ET.Enabled = b_TESLIM_ET.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen veri tabanı hatası oluştu.Hatanın nedeni aşağıda belirtilmiştir.\n\n" + ex.ToString());
            }
        }

        private void Form_dashboard_Load(object sender, EventArgs e)
        {
            formlar.AcilacakForm(this,formlar.FRMmenu,p_UST); // Menü Formunu Gösterme
            yenile();
        
        }


        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void b_YENILE_Click(object sender, EventArgs e)
        {
            yenile(); // Yenile butonu
        }

        private void b_TESLIM_ET_Click(object sender, EventArgs e)
        {
            if (dgv_TESLIM_EDILECEK.CurrentCell.Selected == true || dgv_TESLIM_EDILECEK.CurrentRow.Selected == true) // Herhangi bir sütuna tıklandıysa
            {
                try
                {
                    // Eğer ürün teslim edildiyse T_EDILDIMI bilgisi true olur.
                    veritabani.guncelleEkle("update GETIRILEN set GETIRILEN.T_EDILDIMI=true,GETIRILEN.O_YAPILDIMI=true WHERE GETIRILEN.FIS_NO=" + dgv_TESLIM_EDILECEK.CurrentRow.Cells[0].Value.ToString() + "");
                    // Ürün teslim edildiyse ürünün alınacak tutarı kazanca eklenir
                    if (dgv_TESLIM_EDILECEK.CurrentRow.Cells["Ödeme_Yapıldı_Mı"].Value.ToString() != "True")
                    {
                        veritabani.guncelleEkle("insert into KAZANC(K_MIKTAR,K_TARIH,M_ID) values('" + dgv_TESLIM_EDILECEK.CurrentRow.Cells["Tutar"].Value.ToString() + "','" + DateTime.Now.ToString() + "','" + dgv_TESLIM_EDILECEK.CurrentRow.Cells["M_ID"].Value.ToString() + "')");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilinmeyen veri tabanı hatası oluştu.Hatanın nedeni aşağıda belirtilmiştir.\n\n" + ex.ToString());
                } 
                yenile();
            }
            else
            {
                MessageBox.Show("Teslim edilecek ürün seçmediniz!\nLütfen bir ürün seçiniz.");
            }
        }

        private void b_IPTAL_ET_Click(object sender, EventArgs e)
        {
            // İptal et butonu getirilen ürün bilgisini komple siler
            DialogResult cevap = MessageBox.Show("Getirilen ürünü silmek istiyor musunuz ", "Getirilen ürünü sil!", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    //SQL Sorgusu seçilen ürünü
                    veritabani.guncelleEkle("DELETE FROM GETIRILEN where FIS_NO=" + dgv_TESLIM_EDILECEK.CurrentRow.Cells[0].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilinmeyen veri tabanı hatası oluştu.Hatanın nedeni aşağıda belirtilmiştir.\n\n" + ex.ToString());
                }
            }
            yenile();
        }

        private void t_ARA_Click(object sender, EventArgs e)
        {
            t_ARA.Text = "";
        }

        private void t_ARA_TextChanged(object sender, EventArgs e)
        {
            if (t_ARA.Text == "") yenile();
            else
            {
               try
                {
                    // Arama yapıldığında aranan kelimeyi fiş numarasıyla sorgula
                    DataTable aranan = veritabani.veriGetir(veri + " where(GETIRILEN.FIS_NO like '%" + t_ARA.Text + "%') and GETIRILEN.T_EDILDIMI=false ORDER BY GETIRILEN.T_TARIH ASC");
                    dgv_TESLIM_EDILECEK.DataSource = aranan;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilinmeyen veri tabanı hatası oluştur.Hatanın nedeni aşağıda belirtilmiştir.\n\n" + ex.ToString());
                }
            }
        }

        private void t_ARA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Textboxa sadece sayı gir
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08) e.Handled = true;
        }

        private void dgv_TESLIM_EDILECEK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_TESLIM_EDILECEK.CurrentCell.Selected == true || dgv_TESLIM_EDILECEK.CurrentRow.Selected == true) // Herhangi bir sütuna tıklandıysa
                {
                    // Teslim edileceklerden birine tıklandığında Ödenecek tutarı labelda göster
                    if (dgv_TESLIM_EDILECEK.CurrentRow.Cells["Ödeme_Yapıldı_Mı"].Value.ToString() == "True")
                    {
                        l_ODENECEK_TUTAR.Text = " Ödeme \nyapılmış.";
                    }
                    else l_ODENECEK_TUTAR.Text = dgv_TESLIM_EDILECEK.CurrentRow.Cells["Tutar"].Value.ToString() + " ₺ \n ALINACAK";
                    b_IPTAL_ET.Enabled = b_TESLIM_ET.Enabled = true; // Teslim et ve iptal et butonlarını aktif et
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt seçmeniz gerekiyor.");
            }
        }

        private void dgv_TESLIM_EDILEN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
