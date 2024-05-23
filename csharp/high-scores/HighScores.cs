using System.Collections.Generic;
using System.Linq;

public class HighScores(List<int> list)
{
    public List<int> Scores() => list;
    public int Latest() => list.Last();
    public int PersonalBest() => list.Max(); 
    public List<int> PersonalTopThree() => list.OrderByDescending(score => score).Take(3).ToList();
}