using Exceptions;

class Program
{
    static void Main(string[] args)
    {
        
        try
        {

            var result= BadMethod();
            Console.WriteLine(result);
        }
        catch (DivideByZeroException ex) //when (ex.Source=="CAExceptions")
        {
            Console.WriteLine($"you cannot divide by zero");
        }
        finally { Console.WriteLine("finaly"); }


        ////////////////////////////////////////////////////////////////
        var delivery = new Delivery { Id = 1, CustomerName = "abood" };
        
        var service = new DeliveryService();
        try
        {
            service.Start(delivery);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }

    }
    static int BadMethod()
    {
        var x = 4;
        var y = 0;
        return x / y;
    }
}
