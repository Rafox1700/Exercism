def translate(text):
    result = [translate_one_word(word) for word in text.split()]
    return " ".join(result)

def translate_one_word(text):
    vowels = "a", "e", "i", "o", "u"

    if text.startswith(vowels) or text.startswith(("xr", "yt")):
        text += "ay"
        return text
    
    for index, char in enumerate(text):
        if char in (vowels) or char == "y" and index != 0:
            break 
            
    if index != 0 and text[index] == "u" and text[index - 1] == "q":
        text = text[index + 1:] + text[:index + 1] + "ay"
    else:
        text = text[index:] + text[:index] + "ay"
    
    return text