using System.Collections.Generic;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";
        
        var lastSymbol = statement[^1];
        var letters = statement.Where(char.IsLetter);

        return lastSymbol == '?'
            ? AllUpperLetters(letters) ? "Calm down, I know what I'm doing!" : "Sure."
            : AllUpperLetters(letters) ? "Whoa, chill out!" : "Whatever.";
    }

    private static bool AllUpperLetters(IEnumerable<char> input) => input.Any() && input.All(char.IsUpper);
}