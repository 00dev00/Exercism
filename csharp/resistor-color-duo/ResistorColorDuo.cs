using System;
using System.Linq;

public static class ResistorColorDuo
{
    public static int Value(string[] colors) => 
        colors
        .Take(2)
        .Select( 
            (color, index) => (int)Enum
                                    .Parse<Color>(ignoreCase: true, value: color) * (int)Math.Pow(10, 1 - index))
                                    .Sum();

}

public enum Color
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
