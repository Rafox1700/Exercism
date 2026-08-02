ALPHABET = "abcdefghijklmnopqrstuvwxyz"

def encode(plain_text):
    clean = "".join(ALPHABET[-(ord(letter.lower()) - ord("a")) - 1] if letter.isalpha() else letter if letter.isnumeric() else "" for letter in plain_text)
    return " ".join(clean[index:index + 5] for index in range(0, len(clean), 5))


def decode(ciphered_text):
    return "".join(ALPHABET[-(ord(letter.lower()) - ord("a")) - 1] if letter.isalpha() else letter if letter.isnumeric() else "" for letter in ciphered_text)