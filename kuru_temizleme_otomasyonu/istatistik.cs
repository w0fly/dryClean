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
    public partial class istatistik : Form
    {
        public istatistik()
        {
            InitializeComponent();
        }

        private void istatistik_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        void yenile()
        {
            DateTime dt = DateTime.Today;
            int yil = dt.Year;
            int ay = dt.Month;
            int gun = dt.Day;
            DataTable kazanc = veritabani.veriGetir("select MUSTERILER.M_ADI_SOYADI,KAZANC.K_MIKTAR from KAZANC inner join MUSTERILER on MUSTERILER.M_ID = KAZANC.M_ID ORDER BY KAZANC.K_MIKTAR DESC");
            dgv_KAZANC.DataSource = kazanc;
            DataTable bugünToplam = veritabani.veriGetir("Select SUM(K_MIKTAR) as K_MIKTAR From KAZANC where (K_TARIH like '%" + gun + "." + ay + "." + yil + "%')");
            DataTable dunToplam = veritabani.veriGetir("Select SUM(K_MIKTAR) as K_MIKTAR From KAZANC where (K_TARIH like '%" + (gun - 1) + "." + ay + "." + yil + "%')");
            DataTable buYil = veritabani.veriGetir("Select SUM(K_MIKTAR) as K_MIKTAR From KAZANC");
            l_BUGUN.Text = "Bugünkü kazanç \n" + bugünToplam.Rows[0]["K_MIKTAR"].ToString() + "₺";
            l_DUN.Text = "Dünkü kazanç \n" + dunToplam.Rows[0]["K_MIKTAR"].ToString() + "₺";
            l_SON1YIL.Text = "Bugüne kadar ki toplam \n" + buYil.Rows[0]["K_MIKTAR"].ToString() + "₺";
        }

        private void istatistik_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yenile();
        }
    }
}
