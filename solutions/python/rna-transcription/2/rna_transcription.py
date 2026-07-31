def to_rna(dna_strand):
    match = str.maketrans("GCTA", "CGAU")
    return dna_strand.translate(match)