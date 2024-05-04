using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input) {
        var englishAlphabet = getAlphabet();
        int uniqueLetters = 0;
        input = input.ToLowerInvariant();

        foreach (char ch in input)
        {
            if (englishAlphabet.TryGetValue(ch, out var value) && !value)
            {
                uniqueLetters++;
                englishAlphabet[ch] = true;
            }
        }

        return uniqueLetters == englishAlphabet.Count;
    }

    private static Dictionary<char, bool> getAlphabet()
    {
        Dictionary<char, bool> res = [];

        for (int i = 97; i < 123; i++)
        {
            res.Add((char)i, false);
        }

        return res;
    }
}
