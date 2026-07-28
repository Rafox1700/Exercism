def is_pangram(sentence):
    alphabet = set("abcdefghijklmnopqrstuvwxyz")
    sentence = sentence.lower()
    letters = {c for c in sentence if c.isalpha()}
    return letters == alphabet