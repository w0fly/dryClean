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
    class formlar
    {
        public static Form_Giris FRMgiris = new Form_Giris();
        public static menu FRMmenu = new menu();
        public static dashboard FRMdashboard = new dashboard();
        public static yenimusteri FRMmusteriler = new yenimusteri();
        public static istatistik FRMistatistik = new istatistik();
        public static kullanicilar FRMkullanicilar = new kullanicilar();
        public static musteris FRMmusteri = new musteris();
        public static urunler FRMurunler = new urunler();
        public static ayarlar FRMayarlar = new ayarlar();

        public static void AcilacakForm(Form simdiki, Form Acilacak, Panel ap)
        {
            //Ama başka formlarda olsa hepsini teker teker kontrol eder...
            bool durum = false;
            foreach (Form eleman in simdiki.MdiChildren)
            {
                if (eleman.Text == Acilacak.Text)//Eğer Form2 Form1 üzerinde açık ise :
                {
                    durum = true;//Eğer Form2 Form1 üzerinde açık ise durum=true
                    eleman.Activate();//Form2'yi Aktif eder...
                }
            }
            if (!durum)//Eğer Form2 Form1 üzerinde açık değilse :
            {
                Acilacak.MdiParent = simdiki;//Form2'nin ana penceresi olarak Form1 i ayarlar..
                ap.Controls.Add(Acilacak);
                Acilacak.Show();//Form2'yi açar
                Acilacak.Dock = DockStyle.Top;
                Acilacak.BringToFront();

            }
        }
    }
}
