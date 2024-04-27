using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

    public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) {
        var dayTime = appointmentDate.TimeOfDay;
        return dayTime >= new TimeSpan(12, 0, 0) && dayTime < new TimeSpan(18, 0, 0);
    }

    public static string Description(DateTime appointmentDate) =>
    $"You have an appointment on {appointmentDate.ToShortDateString()} {appointmentDate.ToLongTimeString()}.";

    public static DateTime AnniversaryDate() => new(DateTime.Now.Year, 09, 15);
}
