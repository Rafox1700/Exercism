def resistor_label(colors):
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

    TOLERANCE = {"grey": "0.05",
                 "violet": "0.1",
                 "blue": "0.25",
                 "green": "0.5",
                 "brown": "1",
                 "red": "2",
                 "gold": "5",
                 "silver": "10"}

    PREFIX = ["giga", "mega", "kilo"]
    
    if len(colors) == 1:
        return "0 ohms"

    num = sum(COLORS.index(color) * 10 ** index for index, color in enumerate(colors[-3::-1])) * 10 ** COLORS.index(colors[-2])

    N = 10 ** 9
    prefix = ""
    for index in range(3):
        if num // N > 0:
            num /= N
            prefix = PREFIX[index]
            break
        N /= 1000
        
    return f"{num:g} {prefix}ohms ±{TOLERANCE[colors[-1]]:}%"
