using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kuru_temizleme_otomasyonu
{
    public partial class urunler : Form
    {
        public urunler()
        {
            InitializeComponent();
        }

        private void urunler_FormClosing(object sender, FormClosingEventArgs e)
        {
            yenile();
            this.Hide();
            e.Cancel = true;
        }

        void yenile() 
        {
            DataTable urunler = veritabani.veriGetir("select * from URUN");
            dgv_URUNLER.DataSource = urunler;
            dgv_URUNLER.Columns["U_ID"].Visible = b_URUN_DUZENLE.Visible = b_URUNU_SIL.Visible = false;
            b_URUN_EKLE.Visible = true;
            pictureBox1.Image = null;
            t_URUN_ADI.Text = t_URUN_FIYATI.Text = urunADI = "";
        }

        private void urunler_Load(object sender, EventArgs e)
        {
            yenile();
        }
        string urunADI,urunRESMI = "";
        private void dgv_URUNLER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_URUNLER.CurrentCell.Selected == true || dgv_URUNLER.CurrentRow.Selected == true) // Herhangi bir sütuna tıklandıysa
                {
                    t_URUN_ADI.Text = urunADI = dgv_URUNLER.CurrentRow.Cells["U_TIPI"].Value.ToString();
                    t_URUN_FIYATI.Text = dgv_URUNLER.CurrentRow.Cells["U_FIYATI"].Value.ToString();
                    pictureBox1.ImageLocation = urunRESMI = dgv_URUNLER.CurrentRow.Cells["U_RESMI"].Value.ToString();
                    b_URUN_EKLE.Visible = false;
                    b_URUN_DUZENLE.Visible = b_URUNU_SIL.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt seçmeniz gerekiyor.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yenile();
        }
        string resimPath;
        private void b_RESIM_EKLE_Click(object sender, EventArgs e)
        {
            ofd.Title = "Resim Aç";
            ofd.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                resimPath = ofd.FileName.ToString();
            }
        }

        private void b_URUN_EKLE_Click(object sender, EventArgs e)
        {
            if (t_URUN_ADI.Text != "" || t_URUN_FIYATI.Text != "")
            {
                try
                {
                veritabani.guncelleEkle("insert into URUN(U_FIYATI,U_TIPI,U_RESMI) values('" + t_URUN_FIYATI.Text + "','" + t_URUN_ADI.Text + "','" + ((ofd.FileName.ToString() != "openFileDialog1") ? ofd.FileName.ToString() : @"resimler\urunler\yok.png") + "')");
                MessageBox.Show("Ürün başarıyla eklendi!");
                yenile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilinmeyen veri tabanı hatası oluştur.Hatanın nedeni aşağıda belirtilmiştir.\n\n" + ex.ToString());
                }
            }
            else MessageBox.Show("Ürün bilgilerini boş bırakmayınız!");
        }

        private void b_URUNU_SIL_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Ürünü silmek istiyor musunuz ?", "Ürün siliniyor!", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                veritabani.guncelleEkle("DELETE FROM URUN where U_TIPI='" + urunADI + "'");
                MessageBox.Show("Ürün başarıyla silindi.");
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu isimde bir ürün bulunamadı!");
            }
            yenile();
        }

        private void t_URUN_FIYATI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08) e.Handled = true;
        }

        private void b_URUN_DUZENLE_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Ürünü düzenlemek istiyor musunuz ?", "Ürün düzenleniyor!", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.Yes)
                {
                    veritabani.guncelleEkle("update URUN set U_TIPI='" + t_URUN_ADI.Text + "', U_FIYATI='" + t_URUN_FIYATI.Text + "',U_RESMI='" + ((ofd.FileName.ToString() != "openFileDialog1") ? ofd.FileName.ToString() : urunRESMI) + "' where U_TIPI='" + urunADI +"'");
                    MessageBox.Show("Ürün başarıyla düzenlendi.");
                    yenile();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!");
            }
        }
    }
}
