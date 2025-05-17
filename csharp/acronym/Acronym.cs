using System.Linq;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        phrase = Regex.Replace(phrase, @"[^a-zA-Z  ']", " ");
        var chars = Regex.Split(phrase, @"\s+|-").Select(word => char.ToUpper(word[0]));

        return string.Concat(chars);
    }
}