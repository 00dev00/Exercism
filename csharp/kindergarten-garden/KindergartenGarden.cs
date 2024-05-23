using System;
using System.Collections.Generic;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden(string diagram)
{
    readonly string[] children = [
        "Alice", "Bob", "Charlie", "David",
        "Eve", "Fred", "Ginny", "Harriet",
        "Ileana", "Joseph", "Kincaid", "Larry"
    ];
    public IEnumerable<Plant> Plants(string student)
    {
        var rows = diagram.Split("\n", StringSplitOptions.RemoveEmptyEntries);
        var childIndex = Array.BinarySearch(children, student);

        if (childIndex < 0) throw new ArgumentException("Unknown child");
        List<Plant> childPlants = [];

        for (int i = 0; i < 2; i++)
        {
            if (rows[i].Length >= (childIndex * 2 + 2))
            {
                childPlants.Add(GetPlantNameByChar(rows[i][childIndex * 2]));
                childPlants.Add(GetPlantNameByChar(rows[i][childIndex * 2 + 1]));
            }
        }

        return childPlants;
    }

    private Plant GetPlantNameByChar(char ch) => char.ToUpperInvariant(ch) switch
    {
        'V' => Plant.Violets,
        'R' => Plant.Radishes,
        'C' => Plant.Clover,
        'G' => Plant.Grass,
        _ => throw new ArgumentException("Unknown plant")
    };
}