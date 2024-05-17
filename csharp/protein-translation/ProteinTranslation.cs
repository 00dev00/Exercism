using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    private static readonly Dictionary<string, string> codonToPolypeptide = new() {
        ["AUG"] = "Methionine",
        ["UUU"] = "Phenylalanine",
        ["UUC"] = "Phenylalanine",
        ["UUA"] = "Leucine",
        ["UUG"] = "Leucine",
        ["UCU"] = "Serine",
        ["UCC"] = "Serine",
        ["UCA"] = "Serine",
        ["UCG"] = "Serine",
        ["UAU"] = "Tyrosine",
        ["UAC"] = "Tyrosine",
        ["UGU"] = "Cysteine",
        ["UGC"] = "Cysteine",
        ["UGG"] = "Tryptophan",
        ["UAA"] = "STOP",
        ["UAG"] = "STOP",
        ["UGA"] = "STOP",
    };

    public static string[] Proteins(string strand)
    {
        List<string> proteins = [];

        for (int i = 0; i <= strand.Length - 3; i+=3)
        {
            string codon = string.Concat(strand.Skip(i).Take(3));
            if (codonToPolypeptide[codon] == "STOP") break;
            proteins.Add(codonToPolypeptide[codon]);
        }

        return [.. proteins];
    }
}