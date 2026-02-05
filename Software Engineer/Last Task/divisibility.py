def divisible_by_3_or_5(number):
    if number % 3 == 0 or number % 5 == 0:
        return True
    return False

print(divisible_by_3_or_5(9))