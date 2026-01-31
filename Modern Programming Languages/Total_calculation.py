toplam = 0

for sayi in range(1, 501):
    if sayi % 4 == 0 or sayi % 7 == 0:
        toplam += sayi

print(toplam)
