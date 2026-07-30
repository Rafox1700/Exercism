def label(colors):
    COLORS = ["black",
             "brown",
             "red",
             "orange",
             "yellow",
             "green",
             "blue",
             "violet",
             "grey",
             "white"]

    num = (COLORS.index(colors[0]) * 10 + COLORS.index(colors[1])) * 10 ** COLORS.index(colors[2])
    if num // 10 ** 9 > 0:
        return str(num // 10 ** 9) + " gigaohms"
    if num // 10 ** 6 > 0:
        return str(num // 10 ** 6) + " megaohms"
    if num // 10 ** 3 > 0:
        return str(num // 10 ** 3) + " kiloohms"
    return str(num) + " ohms"
