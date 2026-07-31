def is_paired(input_string):
    pairs = []
    for index, char in enumerate(input_string):
        if char == "[":
            pairs.append("bracket")
        elif char == "]":
            if not pairs or pairs[-1] != "bracket":
                return False
            pairs.pop()
        elif char == "{":
            pairs.append("brace")
        elif char == "}":
            if not pairs or pairs[-1] != "brace":
                return False
            pairs.pop()
        elif char == "(":
            pairs.append("paranthese")
        elif char == ")":
            if not pairs or pairs[-1] != "paranthese":
                return False
            pairs.pop()
            
    return not pairs