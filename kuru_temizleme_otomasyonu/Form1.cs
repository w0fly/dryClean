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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1031753634860411279")
            {
                MessageBox.Show("Erişim Tanındı !");
              Form_Giris giris = new Form_Giris();
            giris.Show();
            this.Hide();  
            }
        }
    }
}
