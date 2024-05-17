using System;
using System.Linq;
using System.Text.RegularExpressions;

public class LogParser
{
    public bool IsValidLine(string text) => Regex.IsMatch(text, @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]");
    public string[] SplitLogLine(string text) => Regex.Split(text, @"<.+?>"); 
    public int CountQuotedPasswords(string lines) => Regex.Matches(lines, "\".*(password).*\"", options: RegexOptions.IgnoreCase).Count();
    public string RemoveEndOfLineText(string line) => Regex.Replace(line, @"(\bend-of-line\d+?\b)", "");
    public string[] ListLinesWithPasswords(string[] lines) => lines.Select( line => {
        var matches = Regex.Matches(line, @"(\bpassword\w+?\b)", RegexOptions.IgnoreCase);

        return matches.Count() > 0 ? $"{matches[0].Value}: {line}" : $"--------: {line}" ;
    } ).ToArray();
}
