ALPHABET = "abcdefghijklmnopqrstuvwxyz"

ATBASH = str.maketrans(ALPHABET, ALPHABET[::-1])

def encode(plain_text):
    clean = "".join(letter.lower() for letter in plain_text if letter.isalnum()).translate(ATBASH)
    return " ".join(clean[index:index + 5] for index in range(0, len(clean), 5))


def decode(ciphered_text):
    return "".join(letter.lower() for letter in ciphered_text if letter.isalnum()).translate(ATBASH)