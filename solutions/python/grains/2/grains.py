def square(number):
    if not (0 < number <= 64):
        raise ValueError("square must be between 1 and 64")
    return 2 ** (number - 1)


def total():
    result = 0
    for number in range(64):
        result += square(number + 1)
    return result