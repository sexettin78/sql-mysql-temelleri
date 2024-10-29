import sqlite3
db = sqlite3.connect("kitap.db")
cr = db.cursor()
isim = input("Teknolojik alet ismi giriniz:")
fiyat = int(input("Fiyat giriniz:"))
cr.execute(f"insert into teknolojikaletler values ('{isim}', {fiyat})")
db.commit()
print("Kayıt başarıyla eklendi!")
db.close()
