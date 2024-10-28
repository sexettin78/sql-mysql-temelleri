using System;
using System.Data.SqlClient;
namespace SqlBaglantisiOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            string baglanti = ("Data Source=PC\\SQLEXPRESS;Initial Catalog=kitap; Integrated Security=True;");
            KomutGir("insert into ogrenciler values('armin', 'g', 13, 60, 90);", baglanti);
        }
        private static void KomutGir(string komut, string baglantiyazi)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiyazi))
            {
                SqlCommand command = new SqlCommand(komut, baglanti);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
