"""def check_Triangle(a, b, c):
    if a + b > c and a + c > b and b + c > a:
        return True
    else:
        return False
"""

def fibonacci(n):
    if n == 0:
        return 0
    elif n == 1:
        return 1
    else:
        return fibonacci(n-1) + fibonacci(n-2)

"""print(check_Triangle(1, 1, 1))"""

print(fibonacci(10))