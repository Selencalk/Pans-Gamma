def is_prime(n):
    if n < 2:
        return False
    for i in range(2, int(n ** 0.5) + 1): # It is checked whether it can be divided from 2 to the square root
        if n % i == 0:
            return False
    return True


def fibonacci_numbers(limit):
    fibs = [0, 1]
    while fibs[-1] < limit: # Continue as long as the last number of Fibonacci is less than the limit
        fibs.append(fibs[-1] + fibs[-2]) 
    return set(fibs)


fib_set = fibonacci_numbers(1000)

count = 0
numbers = []  # Holds numbers that are both prime and Fibonacci

for num in range(1, 1000):
    if num in fib_set and is_prime(num):
        count += 1
        numbers.append(num)

print("Prime & Fibonacci numbers:", numbers)
print("Count:", count)
