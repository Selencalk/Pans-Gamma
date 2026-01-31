import random

def the_smallest(a, b, c):
    if a <= b:
        m = a
    else:
        m = b

    if c < m:
        m = c

    return m

a = random.randint(1, 1000)
b = random.randint(1, 1000)
c = random.randint(1, 1000)

print(a, b, c)
print("En Küçük:", the_smallest(a, b, c))
