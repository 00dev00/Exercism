static class SavingsAccount
{
    public static float InterestRate(decimal balance) => balance switch
    {
        < 0 => 3.213F,
        >= 0 and < 1000 => 0.5F,
        >= 1000 and < 5000 => 1.621F,
        _ => 2.475F
    };

    public static decimal Interest(decimal balance) => balance * (decimal)(InterestRate(balance) / 100);

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int year = 0;

        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            year++;
        }

        return year;
    }
}
