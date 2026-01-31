import numpy as np
import matplotlib.pyplot as plt

x = np.linspace(-5, 5, 400)
y = x**2 - 2

plt.figure(figsize=(7,5))
plt.plot(x, y)
plt.axhline(0)
plt.axvline(0)
plt.title("Grafik: f(x) = x^2 - 2")
plt.xlabel("x")
plt.ylabel("f(x)")
plt.grid(True)

plt.savefig("f_plot.png", dpi=150)
plt.show()
