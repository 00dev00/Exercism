using System;
using System.Linq;

public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        var reverse = (commandValue & 16) != 0;
        var actions =
        Enum
        .GetValues<Actions>()
        .Where(action => ((int)action & commandValue) != 0 && action != Actions.Reverse)
        .Select(action => action switch
            {
                Actions.Wink => "wink",
                Actions.DoubleBlink => "double blink",
                Actions.CloseYourEyes => "close your eyes",
                _ => "jump",
            }
        );
        return reverse ? actions.Reverse().ToArray() : actions.ToArray();
    }
}

[Flags]
file enum Actions
{
    None = 0,
    Wink = 1,
    DoubleBlink = 1 << 1,
    CloseYourEyes = 1 << 2,
    Jump = 1 << 3,
    Reverse = 1 << 4,
}
