using System.Collections.Generic;
using System.Text;

public static class Raindrops
{
    public static string Convert(int number)
    {
        Dictionary<int, string> dict = new(){ [3] = "Pling", [5] = "Plang", [7] = "Plong" };
        StringBuilder sb = new();

        foreach (KeyValuePair<int, string> pair in dict)
        {
            if (number % pair.Key == 0) sb.Append(pair.Value);

        }

        if (sb.Length == 0)
            sb.Append(number);

        return sb.ToString();
    }
}