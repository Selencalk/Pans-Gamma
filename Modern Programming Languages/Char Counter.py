s = "Jaroslaw, Przemyśl, Rzeszów, Kraków"

# Tüm harfleri küçük harfe çevir
s = s.lower()

# Kullanıcıdan harf al
harf = input("Hangi harfin sayısını öğrenmek istiyorsunuz? ").lower()

# Sadece harfleri say
char_count = {}
for ch in s:
    if ch.isalpha():
        char_count[ch] = char_count.get(ch, 0) + 1

# Sonucu göster
adet = char_count.get(harf, 0)
print(f"'{harf}' harfi metinde {adet} kez geçiyor.")
