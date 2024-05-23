using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        int input = number;
        int length = number.ToString().Length;
        int sum = 0;
        
        do
        {
            sum += (int)Math.Pow(number % 10, length);
            number /= 10;
        } while (number > 0);

        return sum == input;
    }
}