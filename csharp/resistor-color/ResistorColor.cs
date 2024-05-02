using System;
using System.Linq;

public static class ResistorColor
{
    public static int ColorCode(string color) => (int)Enum.Parse<BandColor>(color, true);

    public static string[] Colors() => Enum.GetNames<BandColor>().Select( name => name.ToLower() ).ToArray();
}

internal enum BandColor
{
    Black = 0,
    Brown,
    Red,
    Orange,
    Yellow,
    Green,
    Blue,
    Violet,
    Grey,
    White,
}