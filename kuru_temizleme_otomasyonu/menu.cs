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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            p_K.ImageLocation = @"resimler\menu\kullanicilar.png";
            p_A.ImageLocation = @"resimler\menu\ayarlar.png";
            p_I.ImageLocation = @"resimler\menu\istatistik.png";
            p_U.ImageLocation = @"resimler\menu\urun.png";
            p_Mu.ImageLocation = @"resimler\menu\musteri.png";
            p_M.ImageLocation = @"resimler\menu\arti.png";
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.BorderStyle = BorderStyle.None;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            p_K.Visible = label1.Visible = p_A.Visible = label2.Visible = label3.Visible = label4.Visible = p_I.Visible = p_U.Visible = false;
            veritabani.kullaniciBilgisi.Rows.Clear();
            veritabani.kullaniciBilgisi = veritabani.veriGetir("select * from KULLANICILAR");
            formlar.FRMgiris.Show();
            this.Parent.Parent.Hide();
        }

        private void p_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb.Name == "p_K") formlar.FRMkullanicilar.Show();
            else if (pb.Name.ToString() == "p_A") formlar.FRMayarlar.Show();
            else if (pb.Name.ToString() == "p_I") formlar.FRMistatistik.Show();
            else if (pb.Name.ToString() == "p_U") formlar.FRMurunler.Show();
            else if (pb.Name.ToString() == "p_Mu") formlar.FRMmusteri.Show();
            else if (pb.Name.ToString() == "p_M") formlar.FRMmusteriler.Show();
            if (this.Parent.Parent.Name.ToString() != "dashboard") this.Parent.Parent.Hide();
        }
    }
}
