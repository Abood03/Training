class Program
{
    static void Main(string[] args)
    {
        Action<string> action = Print;
        action("abood");
        Func<int,int,int> addd = Add;
        Console.WriteLine((addd(1, 3))) ;
        Predicate<int> predicate = IsEven;
        Console.WriteLine(predicate(5));
        
    }
    static void Print (string s)=>Console.WriteLine(s);  
    static int Add(int x ,int y) { return x + y; }
    static bool IsEven(int n) => n % 2 == 0;
}