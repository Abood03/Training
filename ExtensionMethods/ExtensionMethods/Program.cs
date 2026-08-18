class Program 
{
    static void Main(string[] args)
    {
        DateTime d = DateTime.Now;
        Console.WriteLine(d);
        //d = new DateTime(2004, 6, 9, 4, 15, 00);//yyyy-mm-dd-mm:ss
        //Console.WriteLine(d);
        DateTimeOffset dfs= DateTimeOffset.Now;
        Console.WriteLine(dfs); //GMT utc 
        d = d.AddDays(5);
        Console.WriteLine(d.Day);
        Console.WriteLine($"is weekend: {d.IsWeekend()}");
        Console.WriteLine($"is weekeDay: {d.IsWeekDay()}");
        Console.WriteLine($"is Leap year: {DateTime.IsLeapYear(2004)}");
        Pizza p =new Pizza();
        p = PizzaExtensions.AddDough(PizzaExtensions.AddSouce(PizzaExtensions.AddCheeze(p, true)), "Dough");
        Console.WriteLine(p);
    }

}
public static class PizzaExtensions
{
    public static Pizza AddDough(this Pizza value ,string type)
    {
        value.Contant += $"\n{type} Dough x $2.00";
        value.TotalPrice += 2;
        return value;
    }
    public static Pizza AddSouce(this Pizza value )
    {
        value.Contant += $"\nsauce x $1.00";
        value.TotalPrice += 1;
        return value;
    }
    public static Pizza AddCheeze(this Pizza value,bool extra )
    {
        value.Contant += $"\n{(extra?"extra":"regular")}cheeze souce x {(extra?"4.00":"2.00")}";
        value.TotalPrice += extra?4m:2m;
        return value;
    }
}
public class Pizza
{
    public string Contant {  get; set; }
    public decimal TotalPrice {  get; set; }
    public override string ToString()
    {
        return $"{Contant}\n --------------------\nTotal Price :$ {TotalPrice.ToString("#.##")}";
    }
}