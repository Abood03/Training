using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        /* BankAccount account =new BankAccount("a123","abood",1000);
           account.OnNegativeBalance += Account_OnNegativeBalance;
           account.Withdraw(500);
           Console.WriteLine(account);
           Console.WriteLine(account);
           account.Withdraw(600);*/
        var path = "\"D:\\Training\\ReflectionAndMetaData\\ReflectionAndMetaData\\bin\\Debug\\net10.0\\ReflectionAndMetaData.dll\"";
        var path1 = @"D:\Training\ReflectionAndMetaData\ReflectionAndMetaData\\bin\Debug\\net10.0\ReflectionAndMetaData.dll\";
        var assembly=Assembly.LoadFile(path1);
        Console.WriteLine("MemberInfo");
        MemberInfo[] members = typeof(BankAccount).GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (var item in members)

        {
            Console.WriteLine(item);
        }
        Console.WriteLine("FieldInfo");
        FieldInfo[] fields = typeof(BankAccount).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (var item in fields)

        {
            Console.WriteLine(item);
        }
        Console.WriteLine("PropertyInfo");
        PropertyInfo[] properties = typeof(BankAccount).GetProperties();
        foreach (var item in properties)

        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Event Info");
        EventInfo[] events = typeof(BankAccount).GetEvents();
        foreach (var item in events)

        {
            Console.WriteLine(item);
        }
        Console.WriteLine("ConstructorInfo");

        ConstructorInfo[] ctors = typeof(BankAccount).GetConstructors();
        foreach (var item in ctors)

        {
            Console.WriteLine(item);
        }

    }


    private static void Account_OnNegativeBalance(object? sender, EventArgs e)
    {
        var bankAccount =(BankAccount)sender;
        Console.WriteLine("Negative Balance!!!");
    }
}
public class BankAccount
{
    private string accountNo;
    private string holder;
    private decimal balance;
    public string AccountNo => accountNo;
    public string Holder => holder;
    public decimal Balance => balance;
    public event EventHandler OnNegativeBalance;
    public BankAccount(string accountNo, string holder, decimal balance)
    {
        this.accountNo = accountNo;
        this.holder = holder;
        this.balance = balance;
    }
    public void Deposit (decimal amount)
    {
        this.balance += amount;

    }
    public void Withdraw (decimal amount)
    {
        this.balance -= amount;
        if (this.balance < 0)
        {
            this.OnNegativeBalance.Invoke(this, null);
        }
    }
    public override string ToString()
    {
        return $"{{Account No: {accountNo}, Holder {holder}, Balance: {balance}}}";
    }
}