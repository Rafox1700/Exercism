def is_valid(isbn):
    isbn = isbn.replace("-", "")
    if not isbn or len(isbn) != 10 or not all(char in "0123456789" or char == "X" and index == 9 for index, char in enumerate(isbn)):
        return False
    isbn_list = [10 if char == "X" else int(char) for char in isbn]
    return sum(num * (10 - index) for index, num in enumerate(isbn_list)) % 11 == 0