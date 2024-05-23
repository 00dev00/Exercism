using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder sb = new StringBuilder();
        static string spellBottle(int i) => i == 1 ? "1 bottle" : $"{i} bottles";

        for (int i = startBottles; i > startBottles - takeDown; i--)
        {
            if (i == 0)
            {
                sb.Append(@"No more bottles of beer on the wall, no more bottles of beer.\n
                Go to the store and buy some more, 99 bottles of beer on the wall.");
                break;
            }

            var firstLine = $"{spellBottle(i)} of beer on the wall, {spellBottle(i)} of beer.\n";
            var secondLine = i == 1 ?
                            "Take it down and pass it around, no more bottles of beer on the wall.\n" :
                            $"Take one down and pass it around, {spellBottle(i-1)} of beer on the wall.{(string.IsNullOrWhiteSpace(lastLine) ? "" : "\n")}";
            var fullStr = string.Concat(firstLine, secondLine);
            sb.Append(fullStr);
        }

        return sb.ToString();
    }
}