def rebase(input_base, digits, output_base):
    if input_base < 2:
        raise ValueError("input base must be >= 2")
    if output_base < 2:
        raise ValueError("output base must be >= 2")
    if not all(0 <= num < input_base for num in digits):
        raise ValueError("all digits must satisfy 0 <= d < input base")

    decimal = sum(num * input_base ** index for index, num in enumerate(digits[::-1]))
    if decimal == 0:
        return [0]

    output = []
    while decimal > 0:
        output.append(decimal % output_base)
        decimal = decimal // output_base

    output.reverse()
    return output