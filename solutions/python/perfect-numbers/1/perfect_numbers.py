def classify(number):
    """ A perfect number equals the sum of its positive divisors.

    :param number: int a positive integer
    :return: str the classification of the input integer
    """
    if number < 1:
        raise ValueError("Classification is only possible for positive integers.")

    aliquot = [i for i in range(1, number // 2 + 1) if number % i == 0]
    if sum(aliquot) == number:
        return "perfect"
    if sum(aliquot) > number:
        return "abundant"
    return "deficient"
