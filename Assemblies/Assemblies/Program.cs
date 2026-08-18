using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        //var type = typeof(Employee);
        //var assemble = type.Assembly;
        //Console.WriteLine(assemble.FullName);
        var assembly= Assembly.GetExecutingAssembly();
        Console.WriteLine(assembly);
    }
}
public class Employee
{

}