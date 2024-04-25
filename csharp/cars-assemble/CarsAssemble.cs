static class AssemblyLine
{
    const int carsPerHour = 221;
    public static double SuccessRate(int speed) => speed switch
    {
        >= 1 and <= 4 => 1,
        >= 5 and <=8 => 0.9,
        9 => 0.8,
        10 => 0.77,
        _ => 0
    };
    
    public static double ProductionRatePerHour(int speed) => carsPerHour * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}
