def rows(letter):
    if letter == "A":
        return ["A"]
    letter_index = ord(letter) - ord("A") + 1

    diamond = []
    lign = ""
    for index in range(letter_index):
        for i in range(letter_index - index - 1):
            lign += " "
            
        lign += chr(ord("A") + index)
        for i in range(index * 2 - 1):
            lign += " "
        if index != 0: lign += chr(ord("A") + index)
            
        for i in range(letter_index - index - 1):
            lign += " "
        diamond.append(lign)
        lign = ""

    for lign in diamond[-2::-1]:
        diamond.append(lign)

    return diamond