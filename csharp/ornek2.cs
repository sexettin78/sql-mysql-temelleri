using System;
using System.Data.SqlClient;
namespace SqlBaglantisiOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            string baglanti = ("Data Source=PC\\SQLEXPRESS;Initial Catalog=kitap; Integrated Security=True;");
            while (true) {
                Console.WriteLine("[1] - Yemek Ekle");
                Console.WriteLine("[2] - Yemekleri Listele");
                Console.WriteLine("[3] - Çıkış");
                Console.Write("Seçiminizi giriniz:");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1){
                    Console.Write("Yemek ismi giriniz:");
                    string yemekismi = Console.ReadLine();
                    Console.Write("Yemek fiyatı giriniz:");
                    int yemekfiyati = Convert.ToInt32(Console.ReadLine());
                    KomutGir($"insert into yemekler values ('{yemekismi}','{yemekfiyati}')", baglanti);
                    Console.WriteLine("Yemek Eklendi!");
                }
                else if (secim == 2)
                {
                    ListeleYemekler(baglanti);
                }
                else if(secim == 3)
                {
                    break;
                }
                else { Console.WriteLine("Geçersiz Seçim"); }
            }
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


        private static void ListeleYemekler(string baglantiyazi)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiyazi))
            {
                string komut = "SELECT * FROM yemekler";
                SqlCommand command = new SqlCommand(komut, baglanti);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Yemek: {reader["isim"]}, Fiyat: {reader["fiyat"]}");
                }
            }
        }

    }
}
