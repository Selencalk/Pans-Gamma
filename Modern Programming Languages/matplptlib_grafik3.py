import random
import matplotlib.pyplot as plt

x = list(range(1, 16))
y = [random.randint(0, 150) for _ in range(15)]

plt.bar(x, y)
plt.xlabel("X Axis (1–15)")
plt.ylabel("Random Values (0–150)")
plt.title("Random Bar Chart")

plt.show()