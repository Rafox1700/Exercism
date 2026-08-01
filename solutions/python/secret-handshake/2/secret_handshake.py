def commands(binary_str):
    binary = list(binary_str)
    actions = ["wink", "double blink", "close your eyes", "jump"]
    
    if binary[0] == "1":
        binary = binary[1:]
        actions = actions[::-1]
    else:
        binary = binary[:0:-1]

    return [action for num, action in zip(binary, actions) if num == "1"]