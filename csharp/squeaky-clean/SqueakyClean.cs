using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder strBuilder = new(identifier);
        strBuilder = strBuilder
            .Replace(" ", "_")
            .Replace("\0", "CTRL")
            .KebabToCamel()
            .Sanitize();

        return strBuilder.ToString();
    }

    private static StringBuilder KebabToCamel(this StringBuilder stringBuilder)
    {
        int dashIndex = stringBuilder.IndexOf('-');

        if (dashIndex > 0)
        {
            stringBuilder[dashIndex + 1] = char.ToUpper(stringBuilder[dashIndex + 1]);
            stringBuilder.Remove(dashIndex, 1);
        }

        return stringBuilder;
    }

    private static StringBuilder Sanitize(this StringBuilder stringBuilder)
    {
        int i = 0;
        while (i < stringBuilder.Length)
        {
            var isLetter = char.IsLetter(stringBuilder[i]) || stringBuilder[i] == '_';
            var isSmallGreekLetter = stringBuilder[i].isSmallGreekLetter();
            if (!isLetter || isSmallGreekLetter)
            {
                stringBuilder.Remove(i,1);
                continue;
            }

            i++;
        }

        return stringBuilder;
    }

    private static bool isSmallGreekLetter(this char letter)
    {
        const string smallGreekLetters = "αβγδεζηθιλμνξοπρσςτυφχψω";
        return smallGreekLetters.Contains(letter);
    }

    private static int IndexOf(this StringBuilder stringBuilder, char charToSearch)
    {
        for (int i = 0; i < stringBuilder.Length; i++)
        {
            if (stringBuilder[i] == charToSearch)
                return i;
        }

        return -1;
    }
}
