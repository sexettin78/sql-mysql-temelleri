import sqlite3
db = sqlite3.connect("kitap.db")
cr = db.cursor()

while True:
    print("[1] - Ürün Ekle")
    print("[2] - Ürün Listele")
    print("[3] - Ürün Sil")
    print("[4] - Çıkış")
    secim = int(input("Seçiminizi giriniz:"))

    if secim == 1:
        isim = input("Teknolojik alet ismi giriniz:")
        fiyat = int(input("Fiyat giriniz:"))
        cr.execute(f"insert into teknolojikaletler values ('{isim}', {fiyat})")
        db.commit()
        print("Kayıt başarıyla eklendi!")

    elif secim == 2:
        print("İSİM\tFİYAT")
        cr.execute("SELECT * from teknolojikaletler")
        db_list = cr.fetchall()
        for urun in db_list:
            print(urun[0], "\t", urun[1])

    elif secim == 3:
        isim = input("Silinecek Teknolojik alet ismi giriniz:")
        cr.execute("DELETE FROM teknolojikaletler WHERE isim ='"+isim+"'")
        db_list = cr.fetchall()
        db.commit()
        print("Başarıyla silindi")

    elif secim == 4:
        print("Program sonlandırıldı")
        break

    else:
        print("Geçersiz seçim")
db.close()