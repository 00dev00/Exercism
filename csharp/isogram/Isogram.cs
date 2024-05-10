using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word) => word.GroupBy(char.ToLower).All( cg => !char.IsLetter(cg.Key) || cg.Count() == 1);
}
