static class GameMaster
{
    public static string Describe(Character c) => 
    $"You're a level {c.Level} {c.Class} with {c.HitPoints} hit points.";
    public static string Describe(Destination d) =>
    $"You've arrived at {d.Name}, which has {d.Inhabitants} inhabitants.";
    public static string Describe(TravelMethod tm) =>
    $"You're traveling to your destination {(tm == TravelMethod.Walking ? "by walking" : "on horseback")}.";

    public static string Describe(Character c, Destination d, TravelMethod tm = TravelMethod.Walking) =>
    $"{Describe(c)} {Describe(tm)} {Describe(d)}";
}

class Character
{
    public string Class { get; set; }
    public int Level { get; set; }
    public int HitPoints { get; set; }
}

class Destination
{
    public string Name { get; set; }
    public int Inhabitants { get; set; }
}

enum TravelMethod
{
    Walking,
    Horseback
}
