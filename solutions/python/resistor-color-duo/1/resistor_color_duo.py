def value(colors):
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

    return int("".join(str(COLORS.index(color)) for color in colors[:2]))
