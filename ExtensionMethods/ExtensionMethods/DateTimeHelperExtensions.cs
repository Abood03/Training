public static class DateTimeHelperExtensions
{ 

    public static bool IsWeekend( this DateTime value)
    {
        return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;
    }
    public static bool IsWeekDay(this DateTime value)
    {
        return !IsWeekend(value);
    }
}