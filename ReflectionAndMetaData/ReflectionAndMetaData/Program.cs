class Program
{
    static void Main(string[] args)
    { 
        Type t1 =DateTime.Now.GetType();//at run time
        Type t2=typeof(DateTime);//at compile time
        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine($"Full Name: {t1.FullName}");//Namespace.TypeName
        Console.WriteLine($"Name Space: {t1.Namespace}");//Namespace
        Console.WriteLine($"Name: {t1.Name}");//Name
        Console.WriteLine($"Base Type: {t1.BaseType}");//base Type
        Console.WriteLine($"IsPublic: {t1.IsPublic}");//IsPublic
        Console.WriteLine($"Assembly: {t1.Assembly}");//Assembly
        Type t3 = typeof(int[,]);
        Console.WriteLine($"T3 Type: {t3.Name}");
        var nestedTypes = typeof(Employee).GetNestedTypes();
        foreach (var item in nestedTypes)
        {
            Console.WriteLine(item);
        }
        var t4 = typeof(int);
        var interfaces = t4.GetInterfaces();
        foreach (var item in interfaces)
        {
            Console.WriteLine(item);
        }
        //////////////////////////////////////////////////////////////////
        int i = (int)Activator.CreateInstance(typeof(int));
        DateTime dt = (DateTime)Activator.CreateInstance(typeof(DateTime),2021,01,01);
        Console.WriteLine(dt);
        ///////////////////////////////////////////////////////
        Console.Write("Enemy:");
        do
        {
            var input = Console.ReadLine();
            object obj = null;
            try
            {
                var enemy = Activator.CreateInstance(typeof(Program).Assembly.GetName().Name, input);
                obj = enemy.Unwrap();
            }
            catch { }
            switch (obj) {
                case Goon g:
                    Console.WriteLine(g);
                    break;
                case Agar a:
                    Console.WriteLine(a);
                    break;
                case Pixa p:
                    Console.WriteLine(p);
                    break;
                default:
                    Console.WriteLine("Unknown enemy");
                    break;
                
            }

        } while (true);
    }
}
class Employee
{

}
public class Goon
{
    public override string ToString()
    {
        return $"{{speed: {20}, hitPowe: {13}, strength: {7}}}";

    }
}
public class Pixa
{
    public override string ToString()
    {
        return $"{{speed: {23}, hitPowe: {10}, strength: {3}}}";

    }
}
public class Agar
{
    public override string ToString()
    {
        return $"{{speed: {25}, hitPowe: {18}, strength: {27}}}";

    }
}