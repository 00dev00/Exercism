using System.Linq;

public static class ScrabbleScore
{
    public static int Score(string input) => input.Select(letter => char.ToUpper(letter) switch
    {
        'A' or 'E' or 'I' or 'O' or 'U' or 'L' or 'N' or 'R' or 'S' or 'T' => 1,
        'D' or 'G' => 2,
        'B' or 'C' or 'M' or 'P' => 3,
        'F' or 'H' or 'V' or 'W' or 'Y' => 4,
        'K' => 5,
        'J' or 'X' => 8,
        'Q' or 'Z' => 10,
        _ => 0,
    }).Sum();
}