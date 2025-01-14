using Xunit;

public class SecretHandshakeTests
{
    [Fact]
    public void Wink_for_1()
    {
        Assert.Equal(["wink"], SecretHandshake.Commands(1));
    }

    [Fact]
    public void Double_blink_for_10()
    {
        Assert.Equal(["double blink"], SecretHandshake.Commands(2));
    }

    [Fact]
    public void Close_your_eyes_for_100()
    {
        Assert.Equal(["close your eyes"], SecretHandshake.Commands(4));
    }

    [Fact]
    public void Jump_for_1000()
    {
        Assert.Equal(["jump"], SecretHandshake.Commands(8));
    }

    [Fact]
    public void Combine_two_actions()
    {
        Assert.Equal(["wink", "double blink"], SecretHandshake.Commands(3));
    }

    [Fact]
    public void Reverse_two_actions()
    {
        Assert.Equal(["double blink", "wink"], SecretHandshake.Commands(19));
    }

    [Fact]
    public void Reversing_one_action_gives_the_same_action()
    {
        Assert.Equal(["jump"], SecretHandshake.Commands(24));
    }

    [Fact]
    public void Reversing_no_actions_still_gives_no_actions()
    {
        Assert.Empty(SecretHandshake.Commands(16));
    }

    [Fact]
    public void All_possible_actions()
    {
        Assert.Equal(["wink", "double blink", "close your eyes", "jump"], SecretHandshake.Commands(15));
    }

    [Fact]
    public void Reverse_all_possible_actions()
    {
        Assert.Equal(["jump", "close your eyes", "double blink", "wink"], SecretHandshake.Commands(31));
    }

    [Fact]
    public void Do_nothing_for_zero()
    {
        Assert.Empty(SecretHandshake.Commands(0));
    }
}
