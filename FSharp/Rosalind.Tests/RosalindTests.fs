﻿namespace Rosalind.Tests

open Xunit
open FsCheck
open Rosalind

module ``Bioinformatics Stronghlod tests`` =
 
    // DNA : Counting DNA Nucleotides
    let rawDna = "CCCGCCTTCTCTTCGCTTGAGAGTGCGTCGGTTCGGCGGCATTTACGGAGCCACAGCCACAACCC\
                          ACCCTACATCGTAGGTAGTTTAAGGCCAGTCCCTAATGCGTTCGGGGTAGAGTAAGCGAGTCCCT\
                          TCGAGGACCCAAGCTTTTTTCGATGAAACGCGCTTGTATTCTAGTGCTCGCCCGACTACAAGGAG\
                          CCATCGACGTAGGCCGTTAACAAACCTAGATTCTCAGCTGTTTCGTGGAGGACCGCGCAGAAGCT\
                          CCGGATACGCGTTTCGACACGGTAGCCCCCCCGTCTGTGATAGCAGCGAAGAGATTCTTCACAAC\
                          GGTGCGGACTCGAGGGATTCCCTAGTAAGCCTTCGCCCGATCGGGCTACTTACATTCCCTCGCGC\
                          TACTCTCGTAGGGCCAGGTAGGCCAACGCGTTCCGGTACCCGTTTAGTTCTTGTGGGGATCATGG\
                          GAGAGGTATAGTTGCTCGGGCGGGGTGAGCATCGCAGACTCGTTTTTCACTGCGCTCGCGCATCT\
                          GCCACGAGGACATTCGATCATGTGGCGACGTGATCCCTCTTCAGACCTTATCTTGGAGGGCGCAG\
                          CCGTCCGTTCCACCCGAATGTCCGCGGTTTTGGCGACACTGGTAACCTTAGCAGTCAGTACGCGT\
                          AATAGCGACGGGCCCAAGGCTGCGCGTCCACTCGATTGTAGTGCTTCAGGACCTAGCGCTGCTGA\
                          GATAATGGATACAGTAGGCGAAATCGTGATAGTTGCTATGCCGGCCGTAATCAGAACAAACTAAT\
                          GTCGCCAATACTCCACGGCGCACCTATTGACCACGTTTCTTTCCCCATCCCTTTAAATTCCCGCT\
                          GTCCCGGGCATCGGAATAGGAAGGGACTGAGTACTAGAGAGTCCTGCTGGGTC"
 
    [<Fact>]
    let ``DNA : Counting DNA Nucleotides``() =
        let result = dna rawDna = (185, 256, 245, 212)
        Check.Quick result

    [<Fact>]
    let ``DNA' : Counting DNA Nucleotides``() =
        let result = dna' rawDna = [185; 256; 245; 212]
        Check.Quick result