using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColorTrio
{
    static readonly Dictionary<string, int> colorsDict = new()
    {
        ["black" ] = 0,
        ["brown" ] = 1,
        ["red"   ] = 2,
        ["orange"] = 3,
        ["yellow"] = 4,
        ["green" ] = 5,
        ["blue"  ] = 6,
        ["violet"] = 7,
        ["grey"  ] = 8,
        ["white" ] = 9,
    };
    
    public static string Label(string[] colors)
    {
        int ohms = int.Parse(
            string.Concat(
                string.Concat(colors.Take(2).Select(color => colorsDict[color])),
                new string('0', colorsDict[colors[2]])
            )
        );
        return GetOmsWithMetricPrefix(ohms);
    } 

    public static string GetOmsWithMetricPrefix(int ohms) => Math.Log10(ohms) switch
    {
        > 3 and < 6 => $"{ohms/1000} kiloohms",
        > 6 and < 9 => $"{ohms/1_000_000} megaohms",
        _ => $"{ohms} ohms"
    };
}
