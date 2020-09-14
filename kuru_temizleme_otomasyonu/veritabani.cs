using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Drawing;

namespace kuru_temizleme_otomasyonu
{
    class veritabani
    {
        public static string bagcum = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=kt.accdb"; // veritabanı bağlantı cümlesi
        public static DataTable kullaniciBilgisi;
        public static string kullaniciadi = "Şu an giriş yapılmadı";
        public static string rutbe = "";
        public static OleDbConnection bag = new OleDbConnection(bagcum);
        
        public static DataTable veriGetir(string sql) 
        {
            if (bag.State == ConnectionState.Closed)
            {
                bag.Close();
                bag.Open();
            }
            DataTable dt = new DataTable();
            OleDbCommand komut = new OleDbCommand(sql,bag);
            OleDbDataReader dr = komut.ExecuteReader();
            dt.Load(dr);
            bag.Close();
            return dt;
        }

        public static void guncelleEkle(string sql)
        {
            bag.Open();
            OleDbCommand komut = new OleDbCommand(sql, bag);
            komut.ExecuteNonQuery();
            bag.Close();
        }
    }
}
