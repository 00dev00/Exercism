static class LogLine
{
    public static string Message(string logLine)
    {
        var splittedMessage = logLine.Split(":");

        if (splittedMessage.Length == 2)
        {
            return splittedMessage[1].Trim();
        }

        return "";
    }

    public static string LogLevel(string logLine)
    {
        var start = logLine.IndexOf("[");
        var end = logLine.IndexOf("]");
        var result = "INFO";

        if (start != -1 && end != -1 && start < end)
        {
            return logLine.Substring(start + 1, end - start - 1).Trim().ToLowerInvariant();
        }

        return result;
    }

    public static string Reformat(string logLine)
    {
        var message = Message(logLine);
        var logLevel = LogLevel(logLine);
        return $"{message} ({logLevel})";
    }
}
