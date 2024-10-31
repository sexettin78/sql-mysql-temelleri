package kitap;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class Mysql_entegrasyonu {

	public static void main(String[] args) {
		  // Veritabanı bağlantı bilgileri
		String url = "jdbc:mysql://localhost/kitap"; 
		//kitap yerine çalışacağınız veri tabanının ismini giriniz
		String kullanici_adi= "root"; 
		String sifre = "12345678"; 

        try {
            Class.forName("com.mysql.cj.jdbc.Driver");

            Connection conn = DriverManager.getConnection(url, kullanici_adi, sifre);

            String query = "insert into musteriler (isim, soyisim, adres, siparis_adedi) values ('Hakan', 'Doğan', 'Ankara', 15);"; 
            Statement stmt = conn.createStatement();
            stmt.executeUpdate(query);

            conn.close();
        } catch (Exception e) {
            e.printStackTrace();
        }

	}

}
