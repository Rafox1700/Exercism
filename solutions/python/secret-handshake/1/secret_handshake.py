def commands(binary_str):
    binary = list(binary_str)
    actions = ["wink", "double blink", "close your eyes", "jump"]
    
    if binary[0] == "1":
        binary = binary[1:]
        actions = actions[::-1]
    else:
        binary = binary[:0:-1]

    for index, num in enumerate(binary):
        if num == "0":
            actions[index] = ""

    return [action for action in actions if action]