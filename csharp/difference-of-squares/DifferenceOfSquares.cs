using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max) {
        int sum = Enumerable.Range(1, max).Sum();
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max) =>
        Enumerable.Range(1, max).Select( numb => numb * numb).Sum();

    public static int CalculateDifferenceOfSquares(int max) =>
        CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}