using System;
using System.Collections.Generic;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength > numbers.Length || sliceLength < 1) throw new ArgumentException();
        List<string> res = [];
        for (int i = 0; i <= numbers.Length - sliceLength; i++) res.Add(string.Concat(numbers.Skip(i).Take(sliceLength)));
        return [.. res];
    }
}