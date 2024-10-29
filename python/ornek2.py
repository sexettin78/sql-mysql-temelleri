import sqlite3
db = sqlite3.connect("kitap.db")
cr = db.cursor()
cr.execute("SELECT * from teknolojikaletler")
db_list = cr.fetchall()
print(db_list[4][1])