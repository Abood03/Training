class Program
{
    static void Main(string[] args)
    {
        Cashier c = new Cashier(new Cash());
        c.Checkout(99999.99m);
        Cashier c2 = new Cashier(new Mastercard());
        c2.Checkout(99999.99m);
    }
}
class Cashier
{
    private IPayment _payment;
    public Cashier(IPayment payment)//loss capling
    {
        _payment= payment;
    }
    public void Checkout(decimal amount)
    {
        _payment.Pay(amount);
    }
}
interface IPayment
{
    void Pay(decimal amount);
}
class Cash:IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Cash Payment: ${Math.Round(amount,2):N2}");
    }
}
class Dipit:IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Dipit Payment: ${Math.Round(amount,2):N2}");
    }
}
class Mastercard: IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Mastercard Payment: ${Math.Round(amount,2):N2}");
    }
}