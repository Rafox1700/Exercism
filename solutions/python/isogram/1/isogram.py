def is_isogram(phrase):
    letters = [char.lower() for char in phrase if char.isalpha()]
    return len(letters) == len(set(letters))