class Program
{
    static void Main(string[] args)
    { 
        var amount = 100;
        var members = 2;
        members =Reduce(members,2);
        var shere =Distribute(amount,members);
        
    }
    static int Reduce (int members , int value)
    {
        return members-=value;
    }
    static int Distribute (int amount ,int members)
    {
        try
        {
            return amount / members;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unexpected Error {e.Message}");
        }
        finally

        {
            //
        }
        return 0;

     
    }
}