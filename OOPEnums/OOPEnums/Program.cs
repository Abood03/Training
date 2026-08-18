using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine((int)Month.FEB);
        var day = (DAY.SATURDAY|DAY.SUNDAY);
        if (day.HasFlag(DAY.WEEKEND))
        {
            Console.WriteLine("enjoy your Weekend");
        }
        var d = 1;
        if (Enum.IsDefined(typeof(Month), d))
        {
            Console.WriteLine((Month)d);
        }
        foreach (var i in Enum.GetValues(typeof(Month)))
        {
            Console.WriteLine($"{i.ToString()}= {(int)i}");
        }
        {

        }
        Console.ReadKey();
    }
}
enum Month
{
    JAN=1,
    FEB,
    MAR,
    APR,
    MAY,
    JUN,
    JUL,
    AUG,
    SEP,
    OCT,
    NOV,
    DEC

}
enum DAY
{
    NONE=0b_0000_0000,
    MONDAY=0b_0000_0001,
    TUESDAY=0b_0000_0010,
    WEDNESDAY = 0b_0000_0100,
    THURSDAY = 0b_0000_1000,
    FRIDAY = 0b_0001_0000,
    SATURDAY=0b_0010_0000,
    SUNDAY = 0b_0100_0000,
    BUSDAY=MONDAY|TUESDAY|WEDNESDAY|THURSDAY|FRIDAY,
    WEEKEND=SATURDAY| SUNDAY //=0b_0110_0000

}