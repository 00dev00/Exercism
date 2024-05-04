using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => shirtNum switch
    {
        1 => "goalie",
        2 => "left back",
        3 or 4 => "center back",
        5 => "right back",
        6 or 7 or 8 => "midfielder",
        9 => "left wing",
        10 => "striker",
        11 => "right wing",
        _ => throw new ArgumentOutOfRangeException(nameof(shirtNum), "Unknown shirt number")
    };

    public static string AnalyzeOffField(object report) => report switch
    {
        Foul foul => foul.GetDescription(),
        Injury inj => $"Oh no! {inj.GetDescription()} Medics are on the field.",
        Incident incident=> incident.GetDescription(),
        Manager mgr => $"{mgr.Name}{(mgr.Club is null ? null : $" ({mgr.Club})")}",
        string => report?.ToString() ?? "",
        int => $"There are {report} supporters at the match.",
        _ => throw new ArgumentException ("Unknown argument type")
    };
}