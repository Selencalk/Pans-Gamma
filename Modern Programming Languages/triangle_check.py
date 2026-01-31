def is_triangle(a, b, c):
    status = "not possible"
    
    if a + b > c and a + c > b and b + c > a:
        status = "possible"
    else:
        status = "not possible"
        
    return status


print(is_triangle(3, 3, 10))
