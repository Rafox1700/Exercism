def rotate(text, key):
    result = [chr((ord(char) - ord("a") + key) % 26 + ord("a")) if char.islower() 
              else chr((ord(char) - ord("A") + key) % 26 + ord("A")) if char.isupper() 
              else char for char in text]
    return "".join(result)