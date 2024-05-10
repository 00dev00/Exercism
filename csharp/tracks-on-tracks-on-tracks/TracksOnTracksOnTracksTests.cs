using System.Collections.Generic;
using Xunit;
using Exercism.Tests;

public class TracksOnTracksOnTracksTests
{
    [Fact]
    [Task(1)]
    public void NewList()
    {
        Assert.Empty(Languages.NewList());
    }

    [Fact]
    [Task(2)]
    public void ExistingList()
    {
        var expected = new List<string>
        {
            "C#",
            "Clojure",
            "Elm"
        };
        Assert.Equal(expected, Languages.GetExistingLanguages());
    }

    [Fact]
    [Task(3)]
    public void AddLanguage()
    {
        var expected = new List<string>
        {
            "C#",
            "Clojure",
            "Elm",
            "Bash"
        };
        var languages = new List<string>
        {
            "C#",
            "Clojure",
            "Elm"
        };
        Assert.Equal(expected, Languages.AddLanguage(languages, "Bash"));
    }

    [Fact]
    [Task(4)]
    public void CountLanguages()
    {
        var expected = new List<string>
        {
            "C#",
            "Clojure",
            "Elm"
        };
        Assert.Equal(3, Languages.CountLanguages(expected));
    }

    [Fact]
    [Task(5)]
    public void HasLanguage_yes()
    {
        var expected = new List<string>
        {
            "C#",
            "Clojure",
            "Elm"
        };
        Assert.True(Languages.HasLanguage(expected, "Elm"));
    }

    [Fact]
    [Task(5)]
    public void HasLanguage_no()
    {
        var expected = new List<string>
        {
            "C#",
            "Clojure",
            "Elm"
        };
        Assert.False(Languages.HasLanguage(expected, "D"));
    }

    [Fact]
    [Task(6)]
    public void ReverseList()
    {
        var expected = new List<string>
        {
            "Elm",
            "Clojure",
            "C#"
        };
        var languages = new List<string>
        {
            "C#",
            "Clojure",
            "Elm"
        };
        Assert.Equal(expected, Languages.ReverseList(languages));
    }

    [Fact]
    [Task(7)]
    public void IsExciting_yes()
    {
        var expected = new List<string>
        {
            "C#",
            "Clojure",
            "Elm"
        };
        Assert.True(Languages.IsExciting(expected));
    }

    [Fact]
    [Task(7)]
    public void IsExciting_too_many()
    {
        var languages = new List<string>
        {
            "VBA",
            "C#",
            "Clojure",
            "Elm"
        };
        Assert.False(Languages.IsExciting(languages));
    }

    [Fact]
    [Task(7)]
    public void IsExciting_empty()
    {
        var languages = new List<string>();
        Assert.False(Languages.IsExciting(languages));
    }

    [Fact]
    [Task(7)]
    public void IsExciting_single_star()
    {
        var languages = new List<string>
        {
            "C#"
        };
        Assert.True(Languages.IsExciting(languages));
    }

    [Fact]
    [Task(7)]
    public void IsExciting_star_on_second_place_size2()
    {
        var languages = new List<string>
        {
            "F#",
            "C#"
        };
        Assert.True(Languages.IsExciting(languages));
    }

    [Fact]
    [Task(7)]
    public void IsExciting_star_on_second_place_size3()
    {
        var languages = new List<string>
        {
            "F#",
            "C#",
            "Clojure"
        };
        Assert.True(Languages.IsExciting(languages));
    }

    [Fact]
    [Task(7)]
    public void IsExciting_star_on_third_place_size3()
    {
        var languages = new List<string>
        {
            "F#",
            "Clojure",
            "C#",
        };
        Assert.False(Languages.IsExciting(languages));
    }

    [Fact]
    [Task(8)]
    public void RemoveLanguage_yes()
    {
        var expected = new List<string>
        {
            "C#",
            "Elm"
        };
        var languages = new List<string>
        {
            "C#",
            "Clojure",
            "Elm"
        };
        Assert.Equal(expected, Languages.RemoveLanguage(languages, "Clojure"));
    }

    [Fact]
    [Task(8)]
    public void RemoveLanguage_no()
    {
        var expected = new List<string>
        {
            "C#",
            "Clojure",
            "Elm"
        };
        var languages = new List<string>
        {
            "C#",
            "Clojure",
            "Elm"
        };
        Assert.Equal(expected, Languages.RemoveLanguage(languages, "English"));
    }

    [Fact]
    [Task(9)]
    public void IsUnique_yes()
    {
        var languages = new List<string>
        {
            "C#",
            "Clojure",
            "Elm"
        };
        Assert.True(Languages.IsUnique(languages));
    }

    [Fact]
    [Task(9)]
    public void IsUnique_no()
    {
        var languages = new List<string>
        {
            "C#",
            "Clojure",
            "Elm",
            "C#"
        };
        Assert.False(Languages.IsUnique(languages));
    }
}
