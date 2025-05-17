public class Anagram(string baseWord)
{
    public string[] FindAnagrams(string[] potentialMatches)
    {
        var anagrams = new List<string>(capacity: potentialMatches.Length);
        var baseCharMap = CreateCharMap(baseWord);

        foreach (var potentialMatch in potentialMatches)
        {
            Dictionary<char, int> charMap = new(baseCharMap);

            if (potentialMatch.Length != baseWord.Length)
                continue;

            if (string.Equals(baseWord, potentialMatch, StringComparison.InvariantCultureIgnoreCase))
                continue;

            var failed = false;

            foreach (var letter in potentialMatch)
            {
                var candidateLowKey = char.ToLowerInvariant(letter);

                if (charMap.ContainsKey(candidateLowKey))
                    charMap[candidateLowKey]--;
                else
                {
                    failed = !failed;
                    break;
                }
            }

            if (!failed && charMap.Values.All(val => val == 0))
                anagrams.Add(potentialMatch);
        }

        return [.. anagrams];
    }

    private static Dictionary<char, int> CreateCharMap(string input)
    {
        Dictionary<char, int> res = [];

        foreach (var letter in input)
        {
            var lowerChar = char.ToLowerInvariant(letter);

            if (res.ContainsKey(lowerChar))
                res[lowerChar]++;
            else
                res[lowerChar] = 1;
        }

        return res;
    }
}