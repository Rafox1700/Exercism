def find_anagrams(word, candidates):
    result = []

    for candidate in candidates:
        if word.lower() == candidate.lower():
            continue 
        if sorted(word.lower()) == sorted(candidate.lower()):
            result.append(candidate)

    return result