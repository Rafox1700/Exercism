def find_anagrams(word, candidates):
    result = []
    word = word.lower()
    
    for candidate in candidates:
        candidate_lower = candidate.lower()
        if word == candidate_lower:
            continue 
        if sorted(word) == sorted(candidate_lower):
            result.append(candidate)

    return result