using Xunit;
using Exercism.Tests;

public class WizardsAndWarriors2Tests
{
    [Fact]
    [Task(1)]
    public void Describe_warrior_character()
    {
        var character = new Character
        {
            Class = "Warrior",
            Level = 16,
            HitPoints = 89
        };

        Assert.Equal("You're a level 16 Warrior with 89 hit points.", GameMaster.Describe(character));
    }

    [Fact]
    [Task(1)]
    public void Describe_wizard_character()
    {
        var character = new Character
        {
            Class = "Wizard",
            Level = 7,
            HitPoints = 33
        };

        Assert.Equal("You're a level 7 Wizard with 33 hit points.", GameMaster.Describe(character));
    }

    [Fact]
    [Task(2)]
    public void Describe_small_town_destination()
    {
        var destination = new Destination
        {
            Name = "Tol Honeth",
            Inhabitants = 41
        };

        Assert.Equal("You've arrived at Tol Honeth, which has 41 inhabitants.", GameMaster.Describe(destination));
    }

    [Fact]
    [Task(2)]
    public void Describe_large_town_destination()
    {
        var destination = new Destination
        {
            Name = "Ashaba",
            Inhabitants = 1500
        };

        Assert.Equal("You've arrived at Ashaba, which has 1500 inhabitants.", GameMaster.Describe(destination));
    }

    [Fact]
    [Task(3)]
    public void Describe_walking_travel_method()
    {
        Assert.Equal("You're traveling to your destination by walking.", GameMaster.Describe(TravelMethod.Walking));
    }

    [Fact]
    [Task(3)]
    public void Describe_horse_travel_method()
    {
        Assert.Equal("You're traveling to your destination on horseback.", GameMaster.Describe(TravelMethod.Horseback));
    }

    [Fact]
    [Task(4)]
    public void Describe_character_traveling_to_destination_with_explicit_travel_method()
    {
        var character = new Character
        {
            Class = "Wizard",
            Level = 20,
            HitPoints = 120
        };

        var destination = new Destination
        {
            Name = "Camaar",
            Inhabitants = 999
        };

        Assert.Equal("You're a level 20 Wizard with 120 hit points. You're traveling to your destination on horseback. You've arrived at Camaar, which has 999 inhabitants.", GameMaster.Describe(character, destination, TravelMethod.Horseback));
    }

    [Fact]
    [Task(5)]
    public void Describe_character_traveling_to_destination_without_explicit_travel_method()
    {
        var character = new Character
        {
            Class = "Warrior",
            Level = 1,
            HitPoints = 30
        };

        var destination = new Destination
        {
            Name = "Vo Mimbre",
            Inhabitants = 332
        };

        Assert.Equal("You're a level 1 Warrior with 30 hit points. You're traveling to your destination by walking. You've arrived at Vo Mimbre, which has 332 inhabitants.", GameMaster.Describe(character, destination));
    }
}
