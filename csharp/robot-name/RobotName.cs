using System;
using System.Collections.Generic;

public class Robot
{
    public string Name = RandomName.GetRandomName();
    public void Reset() => Name = RandomName.GetRandomName(Name);
}

public static class RandomName
{
    public static string GetRandomName(string oldName = "")
    {
        if (!string.IsNullOrWhiteSpace(oldName)) NamePool.RemoveName(oldName);

        string name;
        do
        {
            int suffix = Random.Shared.Next(100, 1000);
            (char firstLetter, char secondLetter) = ((char)Random.Shared.Next(65, 91), (char)Random.Shared.Next(65, 91)); 

            name = $"{firstLetter}{secondLetter}{suffix}";
        } while (!NamePool.AddName(name));

        return name;
    }
}

public static class NamePool
{
    private readonly static HashSet<string> names = [];
    public static bool AddName(string name) => names.Add(name);
    public static bool RemoveName(string name) => names.Remove(name);
}