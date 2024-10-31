package kitap;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Scanner;
public class Ulkeler_baskentler {
	public static String url = "jdbc:mysql://localhost/kitap"; 
	public static String kullanici_adi= "root"; 
	public static String sifre = "12345678"; 
	public static void main(String[] args) {
		Scanner verial = new Scanner(System.in);
		while(true) {
			System.out.println("[1] - Ülke Ekle");
			System.out.println("[2] - Ülke Listele");
			System.out.println("[3] - Ülke Sil");
			System.out.println("[4] - Çıkış");
			System.out.print("Seçiminizi giriniz:");
			int secim = verial.nextInt();
			verial.nextLine();
			if(secim==1) {
				System.out.print("Ülke ismi giriniz:");
				String ulkeismi = verial.nextLine();
				System.out.print("Başkent ismi giriniz:");
				String baskentismi = verial.nextLine();
guncelleyen_sorgu_calistir("insert into ulkeler_baskentler values ('" + ulkeismi + "','" + baskentismi + "')");
				System.out.println("Ülke başarıyla eklendi");
			}
			
			else if(secim==2) {
				ResultSet rs = listeleyen_sorgu_calistir("select * from ulkeler_baskentler");
				try {
                    while (rs.next()) {
                        System.out.println("Ülke: " + rs.getString(1) + ", Başkent: " + rs.getString(2)); 
                    }
                } catch (Exception e) {
                    e.printStackTrace();
                }
			}
			
			else if(secim==3) {
				System.out.print("Ülke ismi giriniz:");
				String ulkeismi = verial.nextLine();
				guncelleyen_sorgu_calistir("delete from ulkeler_baskentler where ulke='"+ulkeismi+"'");
				System.out.println("Ülke başarıyla silindi");
			}
			
			else if(secim==4) {
				System.out.println("Program sonlandırıldı");
				break;
			}
			else {
				System.out.println("Hatalı giriş yaptınız");
			}
		}
	}
	
	public static int guncelleyen_sorgu_calistir(String sorgu) {
			try {
	            Class.forName("com.mysql.cj.jdbc.Driver");
	            Connection conn = DriverManager.getConnection(url, kullanici_adi, sifre);
	            Statement stmt = conn.createStatement();
	            int rs = stmt.executeUpdate(sorgu);
	            conn.close();    

	            return rs;	            
			}
			catch (Exception e) {
	            e.printStackTrace();}
			return 0;
	}
	
	public static ResultSet listeleyen_sorgu_calistir(String sorgu) {
		try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection conn = DriverManager.getConnection(url, kullanici_adi, sifre);
            Statement stmt = conn.createStatement();
            ResultSet rs = stmt.executeQuery(sorgu);
            return rs;
		}
		catch (Exception e) {
            e.printStackTrace();}
		return null;
	}

}
