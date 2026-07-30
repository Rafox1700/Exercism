def color_code(color):
    table = colors()
    for index, str in enumerate(table):
        if str == color:
            break
    return index


def colors():
    return ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"]
