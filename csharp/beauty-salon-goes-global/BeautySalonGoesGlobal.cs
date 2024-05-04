using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    private static bool IsWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
    private static TimeZoneInfo GetTimeZoneInfo(Location location)
    {
        bool isWindows = IsWindows();
        Dictionary<Location, TimeZoneInfo> tzi = new() {
            {Location.NewYork, TimeZoneInfo.FindSystemTimeZoneById(isWindows ? "US Eastern Standard Time" : "America/New_York")},
            {Location.London, TimeZoneInfo.FindSystemTimeZoneById(isWindows ? "GMT Standard Time" : "Europe/London")},
            {Location.Paris, TimeZoneInfo.FindSystemTimeZoneById(isWindows ? "W. Europe Standard Time" : "Europe/Paris")},
        };

        return tzi[location];
    }

    private static CultureInfo GetCultureInfo(Location location)
    {
        Dictionary<Location, CultureInfo> ci = new() {
            {Location.NewYork, CultureInfo.GetCultureInfo("en-US")},
            {Location.London, CultureInfo.GetCultureInfo("en-GB")},
            {Location.Paris, CultureInfo.GetCultureInfo("fr-FR")},
        };  

        return ci[location];
    }

    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location) =>
    TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(appointmentDateDescription), GetTimeZoneInfo(location));

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) => alertLevel switch
    {
        AlertLevel.Early => appointment.AddDays(-1),
        AlertLevel.Late => appointment.AddMinutes(-30),
        _ => appointment.AddHours(-1).AddMinutes(-45),
    };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location) {
        var tzi = GetTimeZoneInfo(location);

        for (int i = 0; i < 8; i++)
        {
            if (tzi.IsDaylightSavingTime(dt.AddDays(-i)))
                return true;
        }
        
        return false;
    } 

    public static DateTime NormalizeDateTime(string dtStr, Location location) 
    {
        var ci = GetCultureInfo(location);
        return DateTime.TryParse(dtStr, ci, out var dateTime) ? dateTime : new(1, 1, 1, 0, 0, 0);
    }
}