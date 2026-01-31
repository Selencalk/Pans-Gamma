import numpy as np
import matplotlib.pyplot as plt

# x değerleri
x = np.linspace(-10, 10, 400)
# 0 bölü 0 hatasını önlemek için np.sinc fonksiyonu kullanılabilir
# np.sinc(x) aslında sin(πx)/(πx) tanımlar, biz normal sin(x)/x istiyoruz
y = np.sin(x) / x
y[np.isnan(y)] = 1  # x=0 noktasında sin(x)/x = 1 olmalı

# grafiği çiz
plt.figure(figsize=(7,5))
plt.plot(x, y, label="y = sin(x)/x")
plt.axhline(0, color='black', linewidth=0.8)
plt.axvline(0, color='black', linewidth=0.8)
plt.title("Grafik: y = sin(x)/x")
plt.xlabel("x")
plt.ylabel("y")
plt.grid(True)
plt.legend()
plt.show()
