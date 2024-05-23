using System;
using System.Text.RegularExpressions;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide) => 
        new Regex(@"G|C|T|A", RegexOptions.IgnoreCase)
        .Replace(nucleotide, new MatchEvaluator(Evaluator));
    private static string Evaluator(Match match) => match.Value.ToUpper() switch
    {
        "G" => "C",
        "C" => "G",
        "T" => "A",
        "A" => "U",
        _ => throw new ArgumentException("Unknown nucleotide"),
    };
}