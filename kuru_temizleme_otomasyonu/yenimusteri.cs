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
using System.Data.OleDb;

namespace kuru_temizleme_otomasyonu
{
    public partial class yenimusteri : Form
    {
        public yenimusteri()
        {
            InitializeComponent();
        }

        ImageList resimlistesi; // resim listesi
        Image resim;
        ListViewItem item; // ürünler
        string urunID, urunADI = ""; // ürün adı ve id si
        int urunFIYAT = 0; // bir ürünün fiyatı
        int fiyat; // seçilen ürünlerin toplam fiyatı
        List<string> gunler = new List<string>();

        void yenile()
        {
            t_AD.Text = t_ARA.Text = t_TEL.Text = t_ADRES.Text = t_TEL2.Text = secilenler = l_FIYAT.Text = "";
            t_ADET.Text = "1";
            c_ODEME_YAPILDIYSA.Checked = c_MUSTERI_KAYITLIYSA.Checked = false;
            b_CIKART.Enabled = b_EKLE.Enabled = gb_MUSTERI_EKLE.Enabled = t_ADET.Enabled = false;
            fiyat=0;
            lv_SECILEN_URUNLER.Items.Clear();
            try
            {
                lv_URUN_SEC.Items.Clear();
                DataTable urun = veritabani.veriGetir("select * from URUN"); // Ürünleri her yenilediğinde getir.
                urunGoster(urun, lv_URUN_SEC);
                lv_URUN_SEC.LargeImageList = resimlistesi;
                lv_SECILEN_URUNLER.LargeImageList = resimlistesi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen veri tabanı hatası oluştu.Hatanın nedeni aşağıda belirtilmiştir.\n" + ex.ToString());
            }
            formlar.FRMdashboard.b_YENILE.PerformClick();
            gunler.Clear();
        }

        private void musteriler_FormClosing(object sender, FormClosingEventArgs e)
        {
            yenile();
            this.Hide();
            e.Cancel = true;
        }
        private void urunGoster(DataTable dt,ListView lst)
        {
            resimlistesi = new ImageList();
            resimlistesi.ImageSize = new Size(80, 80);
            for (int i = 0; i < dt.Rows.Count; i++)
             {
                 try
                 {
                     if (File.Exists(dt.Rows[i]["U_RESMI"].ToString()))//resimyolunda resim var mı diye kontrol ediyoruz
                         resim = Image.FromFile(dt.Rows[i]["U_RESMI"].ToString());
                     else //resimyolunda resim yoksa 
                     {
                         resim = Image.FromFile(@"resimler\urunler\yok.png");
                         MessageBox.Show(dt.Rows[i]["U_RESMI"].ToString() + " Resim Bulunamadı");
                     }
                     resimlistesi.Images.Add(dt.Rows[i]["U_ID"].ToString(),resim);
                     item = new ListViewItem(dt.Rows[i]["U_TIPI"].ToString() + "\n" + dt.Rows[i]["U_FIYATI"].ToString() + " ₺" + (i % 5 == 0 ? "\n\r" : " "), i);//Ürünü,resmi,grubu bağlıyoruz
                     lst.Items.Add(item);//oluşturduğumuz item i listeye ekliyoruz
                 }
                 catch (Exception ex)
                 {
                      MessageBox.Show("Bilinmeyen veri tabanı hatası oluştu.Hatanın nedeni aşağıda belirtilmiştir.\n" + ex.ToString());
                 }
             }
        }
        private void musteriler_Load(object sender, EventArgs e)
        {
            yenile();
        }
        int resimindex = 0;
        private void listview_Urun_SelectedIndexChanged(object sender, EventArgs e) // Ürün listesinden seçim değiştiyse
        {
            t_ADET.Enabled = b_EKLE.Enabled =l_FIYAT.Enabled = t_ADET.Enabled = true; // aktif edilen nesneler
            t_ADET.Text = "1"; // textboxa adet sayısını 1 yap
            try
            {
                if (lv_URUN_SEC.SelectedItems.Count > 0) // 1 ürün seçildiyse
                {
                    string sorgu = lv_URUN_SEC.SelectedItems[0].ToString().Replace("ListViewItem: {", "").Replace(" TL }",""); // seçilen ürünü bul
                    int bosluk = sorgu.IndexOf('\n');
                    sorgu = sorgu.Remove(bosluk);
                    DataTable secilenURUN = veritabani.veriGetir("Select * from URUN where U_TIPI='" + sorgu + "'");
                    urunID = secilenURUN.Rows[0]["U_ID"].ToString(); // ürünün id sini ata
                    urunFIYAT = Convert.ToInt32(secilenURUN.Rows[0]["U_FIYATI"].ToString());  // ürünün fiyatını ata
                    urunADI = secilenURUN.Rows[0]["U_TIPI"].ToString();  // ürünün adını ata
                    resimindex = resimlistesi.Images.IndexOfKey(secilenURUN.Rows[0]["U_ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bu ürünü seçemezsiniz.");
                yenile();
            }
        }

        private void b_EKLE_Click(object sender, EventArgs e) // EKLE Butonuna basıldığında
        {
            try
            {
                for (int i = 0; i < Convert.ToInt32(t_ADET.Text); i++)
                {
                    ListViewItem yenitem = new ListViewItem(urunADI + "\n" + urunFIYAT + " ₺", resimindex);
                    lv_SECILEN_URUNLER.Items.Add(yenitem);//oluşturduğumuz item i listeye ekliyoruz
                    fiyat = fiyat + urunFIYAT;
                    l_FIYAT.Text = fiyat.ToString() + " TL Toplam Tutar.";
                }
                gunler.Add(t_ADET.Text + " x " + urunADI); // gunler listesine ürün eklenir.
                b_EKLE.Enabled = t_ADET.Enabled = gb_MUSTERI_EKLE.Enabled = l_FIYAT.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen veri tabanı hatası oluştu.Hatanın nedeni aşağıda belirtilmiştir.\n" + ex.ToString());
                yenile();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = lv_SECILEN_URUNLER.SelectedItems[0].ToString().Replace("ListViewItem: {", "").Replace(" TL }", ""); // seçilen ürünü bul
                int bosluk = sorgu.IndexOf('\n');
                sorgu = sorgu.Remove(bosluk);
                DataTable dt = veritabani.veriGetir("Select * from URUN where U_TIPI='" + sorgu + "'");
                fiyat = fiyat - Convert.ToInt32(dt.Rows[0]["U_FIYATI"].ToString()); // fiyatını düştük.
                l_FIYAT.Text = fiyat.ToString() + " TL Toplam Tutar.";
                if (lv_SECILEN_URUNLER.SelectedItems.Count > 0)
                {
                    lv_SECILEN_URUNLER.Items.Remove(lv_SECILEN_URUNLER.SelectedItems[0]); // sildik
                }
                b_CIKART.Enabled = false;
                if (lv_SECILEN_URUNLER.Items.Count == 0)
                {
                    yenile(); // ürün kalmadıysa yeniliyoruz.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen veri tabanı hatası oluştu.Hatanın nedeni aşağıda belirtilmiştir.\n" + ex.ToString());
                yenile();
            }
        }
        string secilenler = ""; // seçilen ürünler örneğin 1 x Pantolon, 1 x Gömlek gibi veri tabanına ekleniyor
        private void button_musteriEkle_Click(object sender, EventArgs e) // Müşteri ekle butonu
        {
            try
            {
                string odemeYapildimi = (c_ODEME_YAPILDIYSA.Checked == true) ? "true" : "false";
                foreach (string item in gunler) { secilenler += item + ","; } // gunler de ki itemleri ekliyoruz
                if (c_MUSTERI_KAYITLIYSA.Checked == true) // kayıtlı müşteri varsa seçildiğinde
                {
                    if (dgv_MUSTERI.CurrentCell.Selected == true || dgv_MUSTERI.CurrentRow.Selected == true) // Herhangi bir sütuna tıklandıysa
                    {
                        veritabani.guncelleEkle("INSERT INTO GETIRILEN(M_ID,G_URUNLER,G_TARIH,T_TARIH,A_TUTAR,O_YAPILDIMI) values('" + dgv_MUSTERI.CurrentRow.Cells["M_ID"].Value.ToString() + "','" + secilenler + "','" + DateTime.Today.ToShortDateString() + "','" + d_TESLIM_TARIHI.Value.ToString() + "','" + fiyat.ToString() + "'," + odemeYapildimi + ")");
                        MessageBox.Show("Ürün Başarıyla Eklendi");
                        if (c_ODEME_YAPILDIYSA.Checked == true)
                        {
                            veritabani.guncelleEkle("insert into KAZANC(K_MIKTAR,K_TARIH,M_ID) values('" + fiyat + "','" + DateTime.Now.ToString() + "','" + dgv_MUSTERI.CurrentRow.Cells["M_ID"].Value.ToString() + "')");
                        }
                        this.Hide();
                    }
                }
                else
                {
                    string m_id;
                    if (t_AD.Text == "")
                    {
                        MessageBox.Show("Lütfen isim giriniz");
                    }
                    else
                    {
                         veritabani.guncelleEkle("INSERT INTO MUSTERILER(M_ADI_SOYADI,M_TEL,M_TEL2,M_ADRES) values('" + t_AD.Text + "','" + t_TEL.Text + "','" + t_TEL2.Text + "','" + t_ADRES.Text + "')");
                         MessageBox.Show("Müşteri Başarıyla Eklendi");
                         DataTable dt = veritabani.veriGetir("select * from MUSTERILER where M_TEL='" + t_TEL.Text + "' or M_TEL2='" + t_TEL2.Text + "';");
                         string mid = dt.Rows[0]["M_ID"].ToString();
                         veritabani.guncelleEkle("INSERT INTO GETIRILEN(M_ID,G_URUNLER,G_TARIH,T_TARIH,A_TUTAR,O_YAPILDIMI) values('" + mid + "','" + secilenler + "','" + DateTime.Today.ToShortDateString() + "','" + d_TESLIM_TARIHI.Value.ToString() + "','" + fiyat.ToString() + "'," + odemeYapildimi + ")");
                         MessageBox.Show("Ürün Başarıyla Eklendi");
                         if (c_ODEME_YAPILDIYSA.Checked == true)
                         {
                             veritabani.guncelleEkle("insert into KAZANC(K_MIKTAR,K_TARIH,M_ID) values('" + fiyat + "','" + DateTime.Now.ToString() + "','" + mid + "')");
                         }
                         this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen veri tabanı hatası oluştu.Hatanın nedeni aşağıda belirtilmiştir.\n" + ex.ToString());
                yenile();
            }
            yenile();
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (c_MUSTERI_KAYITLIYSA.Checked == true)
                {
                    t_ARA.Visible = dgv_MUSTERI.Visible = true;
                    t_AD.Enabled = t_TEL.Enabled = t_TEL2.Enabled = t_ADRES.Enabled = b_MUSTERI_EKLE.Enabled = false;
                    t_ARA.Text = "Müşteri seçin veya adına göre arayın.";
                    DataTable dt = veritabani.veriGetir("Select M_ID,M_ADI_SOYADI,M_TEL,M_TEL2 From MUSTERILER");
                    dgv_MUSTERI.DataSource = dt;
                    dgv_MUSTERI.Columns[0].Visible = false;
                    dgv_MUSTERI.ForeColor = Color.Black;
                }
                else
                {
                    t_ARA.Visible = dgv_MUSTERI.Visible = false;
                    t_AD.Enabled = t_TEL.Enabled = t_TEL2.Enabled = t_ADRES.Enabled = b_MUSTERI_EKLE.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen veri tabanı hatası oluştu.Hatanın nedeni aşağıda belirtilmiştir.\n" + ex.ToString());
                yenile();
            }
        }

        private void textBox_m_ara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable aranan = veritabani.veriGetir("Select M_ID,M_ADI_SOYADI,M_TEL,M_TEL2 From MUSTERILER where(M_ADI_SOYADI like '%" + t_ARA.Text + "%')");
                dgv_MUSTERI.DataSource = aranan;
                dgv_MUSTERI.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen veri tabanı hatası oluştu.Hatanın nedeni aşağıda belirtilmiştir.\n" + ex.ToString());
                yenile();
            }
        }

        private void dataGridView_musteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            b_MUSTERI_EKLE.Enabled = true;
        }

        private void textBox_TEL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08) e.Handled = true;
        }

        private void textBox_m_ara_Click(object sender, EventArgs e)
        {
            t_ARA.Text = "";
        }

        private void musteriler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lv_SECILEN_URUNLER_SelectedIndexChanged(object sender, EventArgs e)
        {
            b_CIKART.Visible = b_CIKART.Enabled = true;
        }

        private void b_YENILE_Click(object sender, EventArgs e)
        {
            yenile();
        }


    }
}
