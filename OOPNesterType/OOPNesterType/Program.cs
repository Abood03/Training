class Program
{
    static void Main(string[] args)
    {
        {
            //scope 1 
            var p = new Person();
            p.Name = "Test";
        }
        {
            //scope 2

        }
        GC.Collect();
    }
}
class Person
{
    public string Name { get; set; }
    public Person()//constructor
    {
        Console.WriteLine("this is person const");
    }
     ~Person() //distructor
    {
        Console.WriteLine("this is person distructor ");
    }
}