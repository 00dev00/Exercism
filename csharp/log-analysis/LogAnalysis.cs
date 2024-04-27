public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        int index = str.IndexOf(delimiter);

        if (index == -1) return "";

        return str[(index + delimiter.Length)..];
    }

    public static string SubstringBetween(
        this string str,
        string firstDelimiter,
        string secondDelimiter
    )
    {
        int firstIndex = str.IndexOf(firstDelimiter);
        int secondIndex = str.IndexOf(secondDelimiter);

        firstIndex = firstIndex == -1 ? 0 : firstIndex + firstDelimiter.Length; 
        secondIndex = secondIndex == -1 ? str.Length - 1 : secondIndex;
        
        return str[firstIndex..secondIndex];
    }

    public static string Message (this string str) => str.SubstringAfter(": ");
    public static string LogLevel (this string str) => str.SubstringBetween("[", "]");
}