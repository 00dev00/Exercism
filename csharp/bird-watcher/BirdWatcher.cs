using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];

    public int Today() => birdsPerDay[^1];
    public void IncrementTodaysCount() => birdsPerDay[^1] += 1;
    public bool HasDayWithoutBirds() => birdsPerDay.Any(birdsCount => birdsCount == 0);
    public int CountForFirstDays(int numberOfDays) => birdsPerDay[..numberOfDays].Sum();
    public int BusyDays() => birdsPerDay.Count(birds => birds >= 5);
}
