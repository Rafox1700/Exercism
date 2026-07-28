def is_pangram(sentence):
    alphabet = "abcdefghijklmnopqrstuvwxyz"
    return all(c in sentence.lower() for c in alphabet)