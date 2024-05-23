using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var sanitizedPN = Regex.Replace(phoneNumber, @"\D", "");
        var match = Regex.Match(sanitizedPN, @"^1?([2-9]{1}\d{2}[2-9]{1}\d{6})$");

        return match.Success ? match.Groups[1].Value : throw new ArgumentException();
    }
}