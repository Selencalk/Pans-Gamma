import random
import matplotlib.pyplot as plt

x = list(range(1, 13))
y = [random.randint(0, 100) for _ in range(12)]

plt.bar(x, y)
plt.xlabel("X Axis (1–12)")
plt.ylabel("Random Values (0–100)")
plt.title("Random Bar Chart")

plt.show()