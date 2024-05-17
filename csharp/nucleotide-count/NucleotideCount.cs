using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var res = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['T'] = 0,
            ['C'] = 0,
            ['G'] = 0
        };

        IEnumerable<IGrouping<char, char>> groups = sequence.GroupBy(c => c);

        foreach (var group in groups)
        {
            res[group.Key] = res.ContainsKey(group.Key) ? group.Count() : throw new ArgumentException("Uknown nucleotide");
        }

        return res;
    }
}