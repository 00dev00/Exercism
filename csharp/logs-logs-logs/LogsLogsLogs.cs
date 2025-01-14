using System.Text.RegularExpressions;

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string pattern = @"\[(.+)\]";
        string logLevel = Regex.Matches(logLine, pattern)[0].Groups[1].Value;

        return logLevel switch
        {
            "TRC" => LogLevel.Trace,
            "DBG" => LogLevel.Debug,
            "INF" => LogLevel.Info,
            "WRN" => LogLevel.Warning,
            "ERR" => LogLevel.Error,
            "FTL" => LogLevel.Fatal,
            _ => LogLevel.Unknown,
        };
    }

    public static string OutputForShortLog(LogLevel logLevel, string message) => $"{(int)logLevel}:{message}";
}

enum LogLevel 
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
}
