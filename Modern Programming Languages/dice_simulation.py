import random

results = [0, 0, 0, 0, 0, 0]

for i in range(1, 1000000):
    dice = random.randint(1, 6)
    results[dice - 1] += 1

for i in range(6):
    print(i + 1, results[i])
