def to_rna(dna_strand):
    DNA = list("GCTA")
    RNA_match = list("CGAU")
    return "".join(RNA_match[DNA.index(char)] for char in dna_strand)