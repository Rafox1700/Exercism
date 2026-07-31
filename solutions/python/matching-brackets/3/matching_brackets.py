def is_paired(input_string):
    open = list("[{(")
    close = list("]})")
    stack = []
    for char in input_string:
        if char in open:
            stack.append(char)
        elif char in close:
            if not stack or open[close.index(char)] != stack.pop():
                return False
    return not stack