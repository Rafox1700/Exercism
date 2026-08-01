def find_anagrams(word, candidates):
    word = word.casefold()

    return [candidate for candidate in candidates if word != candidate.casefold() and sorted(word) == sorted(candidate.casefold())]