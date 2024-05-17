using System;
using System.Globalization;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB) => string.Format("                  {0} ♡ {1}                    ", studentA, studentB);

    public static string DisplayBanner(string stA, string stB) => @$"
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {stA.Trim()}  +  {stB.Trim()}     **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *";

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours)
    {
        var deCul = new CultureInfo("de-DE");
        return $"{studentA} and {studentB} have been dating since {start.ToString("d", deCul)} - that's {hours.ToString("#,#.##", deCul)} hours";
    }
}
