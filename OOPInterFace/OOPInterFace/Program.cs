using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Vehcle v1= new Honda("Honda","civic",2021);
        IDisplace d = new Vehcle();
        d.Move();
        
    }
}
 class Vehcle:IMove,IDisplace //absteact type
{
    protected string Brand;
    protected string Model;
    protected int Year;

    public Vehcle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }
    public Vehcle()
    {
        
    }

    void IMove.Move()
    {
        Console.WriteLine("IMove move");
    }

    void IDisplace.Move()
    {
        Console.WriteLine("IDisplace move");    
    }
}
interface ILoader
{
    void load();
    void unload();
}
interface IDrivable
{
    void Move();
    void Stop();

}
class Honda : Vehcle,IDrivable //concrete
{
    public Honda(string brand ,string model ,int year):base(brand,model,year)
    {
        
    }

    public void Move()
    {
        Console.WriteLine("Moving");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping");
    }
}
class Caterpillar : Vehcle,IDrivable ,ILoader //concrete
{
    public Caterpillar(string brand, string model, int year) : base(brand, model, year)
    {

    }

    public void load()
    {
        Console.WriteLine("loading");
    }

    public void Move()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }

    public void unload()
    {
        Console.WriteLine("Unloading");
    }
    
}
interface IMove
{
    void Move();
}
interface IDisplace
{
    void Move();
}
