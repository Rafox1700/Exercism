def rebase(input_base, digits, output_base):
    if input_base < 2:
        raise ValueError("input base must be >= 2")
    if output_base < 2:
        raise ValueError("output base must be >= 2")
    if not all(0 <= num < input_base for num in digits):
        raise ValueError("all digits must satisfy 0 <= d < input base")

    if not digits or all(num == 0 for num in digits):
        return [0]

    decimal = sum(num * input_base ** (len(digits) - 1 - index) for index, num in enumerate(digits))

    output = []
    while decimal > 0:
        output.append(decimal % output_base)
        decimal = decimal // output_base

    output.reverse()
    return output