class Program
{
    static void Main(string[] args)
    {
        //Animal a1=new Animal(); error
        Eagle e=new Eagle();
        Animal a = e;//upcasting 
        Console.WriteLine(e.GetType());
        Eagle e2 = (Eagle)a;//downcasting
        Falcon f = a as Falcon;//as
        if (a is Falcon)
        {
            Console.WriteLine( "a is a falcon ");
        }
        else
            Console.WriteLine("a is not a falcon ");

        e.Move();
        Console.WriteLine("     ");
        e.Name = "Eagle";
        Console.WriteLine(e);
        Console.ReadKey();
    }
}
abstract class Animal
{
    public string Name {  get; set; }
    public abstract void m();
    public virtual void Move()//virtual any class inhirt can edit on this method
    {
        Console.WriteLine("moving");
    }
    public override string ToString()
    {
        return $"Aminal{Name} is Moveing ";
    }
}

class Eagle :Animal //class can inherit from only a single class but can itself be inherited by many classes
{
    public override void m()
    {
        Console.WriteLine("mm");
    }
    public override void Move()
    {     
        base.Move();
        Console.WriteLine("the Eagle");
    }
    
    public void Fly()
    {
        Console.WriteLine("Flying");
    }
}
class Falcon :Animal //class can inherit from only a single class but can itself be inherited by many classes
{
    public override void m()
    {
        Console.WriteLine("mm");
    }
    public void Fly()
    {
        Console.WriteLine("Flying");
    }
    subClass s=new subClass(323);
}
//seald class cant be inhiretend
class baseClass
{
    public int x;
    public baseClass()
    {
        
    }
    public baseClass(int value)
    {
        x=value;
    }
}
class subClass : baseClass
{
    public subClass(int scVlaue):base (scVlaue)//base class const always execute f this ensures that base initialization
        //occurs before specialized initialization
    {
        
    }
}