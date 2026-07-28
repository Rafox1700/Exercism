def translate(text):
    result = [translate_one_word(word) for word in text.split()]
    return " ".join(result)

def translate_one_word(text):
    vowels = "a", "e", "i", "o", "u"
    index = 0

    if text.startswith(vowels) or text.startswith(("xr", "yt")):
        text += "ay"
        return text
    
    for char in text:
        if char in (vowels) or char == "y" and index != 0:
            break 
        index += 1
            
    if text[index] == "y":
        text = text[index:] + text[:index]
    elif index != 0 and text[index] == "u" and text[index - 1] == "q":
        text = text[index + 1:] + text[:index + 1]
    else:
        text = text[index:] + text[:index]
    
    if text.startswith(vowels) or text.startswith("y"):
        text += "ay"
    
    return text