using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
       double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
       return distance switch
       {
         <= 1 => 10,
         <= 5 => 5,
         <= 10 => 1,
         _ => 0,
       };
    }
}
