class Program{
    static void Main(string[] args)
    {
            DateTime dt = new DateTime(2021, 05, 01, 08, 30, 00);

            dt = dt.AddDays(10);

            Console.WriteLine(dt);

            Console.ReadKey();
    }

}

struct Student
{
    int id; //no inslize
    public int Id { get;set;  }
    public void Show()
    {
        Console.WriteLine("Show");
    }

   /* ~Student()
    {
   error 
    }
   */
}