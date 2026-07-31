def rows(letter):
    if letter == "A":
        return ["A"]
    letter_index = ord(letter) - ord("A") + 1

    diamond = []
    lign = ""
    for index in range(letter_index):
        lign += " " * (letter_index - index - 1)
        lign += chr(ord("A") + index)
        lign += " " * (index * 2 - 1)
        if index != 0: lign += chr(ord("A") + index)
        lign += " " * (letter_index - index - 1)
        diamond.append(lign)
        lign = ""

    for lign in diamond[-2::-1]:
        diamond.append(lign)

    return diamond