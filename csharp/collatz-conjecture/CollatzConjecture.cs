using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(number);
        int step = 0;

        while (number != 1)
        {
            number = number % 2 != 0 ? number * 3 + 1 : number / 2;
            step++;
        }

        return step;
    }
}