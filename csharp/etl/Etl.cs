using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old) => 
        old.SelectMany(kvp => kvp.Value, (kvp, value) => new KeyValuePair<string, int>(value.ToLower(), kvp.Key)).ToDictionary();
}