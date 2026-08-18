public class DateTimeHelper
{
    public static bool IsWeekend( DateTime value)
    {
        return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;
    }
    public static bool IsWeekDay( DateTime value)
    {
        return !IsWeekend(value);
    }
}