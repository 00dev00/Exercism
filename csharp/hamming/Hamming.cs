using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand) =>
        firstStrand.Length != secondStrand.Length ? 
            throw new ArgumentException("Strands must have the same length") :
            firstStrand.Where( (char ch, int index) => secondStrand[index] != ch).Count();
}