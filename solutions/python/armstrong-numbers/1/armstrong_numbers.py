def is_armstrong_number(number):
    power = len(str(number))
    original = number
    total = 0
    while number > 9:
        total += (number % 10) ** power
        number //= 10
    total += number ** power
    if total == original:
        return True
    return False