def square(number):
    if not (number > 0 and number <= 64):
        raise ValueError("square must be between 1 and 64")
    return 2 ** (number - 1)


def total():
    result = 0
    for i in range(64):
        result += square(i + 1)
    return result