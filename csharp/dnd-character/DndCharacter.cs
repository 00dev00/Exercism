using System;
using System.Collections.Generic;
using System.Linq;

public class DndCharacter
{
    public DndCharacter()
    {
        Strength = Ability(); 
        Dexterity= Ability();
        Constitution = Ability();
        Intelligence = Ability();
        Wisdom  = Ability();
        Charisma = Ability();
        Hitpoints = Modifier(Constitution) + 10;
    }
    public int Strength { get; } 
    public int Dexterity { get; } 
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public int Hitpoints { get; }

    public static int Modifier(int score) => (score - 10) >> 1;

    public static int Ability() 
    {
        List<int> rolls = [Random.Shared.Next(1, 7), Random.Shared.Next(1, 7), Random.Shared.Next(1, 7), Random.Shared.Next(1, 7)];
        return rolls.OrderByDescending(n => n).ToList()[0..3].Sum();
    }

    public static DndCharacter Generate() => new();
}
