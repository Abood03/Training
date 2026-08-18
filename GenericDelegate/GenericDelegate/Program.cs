//public delegate bool Filter<in T>(T n);//in data type //out in pracit
class Program
{
    static void Main(string[] args)
    {
        IEnumerable<int> l=new int[] { 1, 3, 4, 2, 5, 6, 7, 8, 9, 10, 11, 12, 13};
        printNUm(l,n=>n>6,()=> Console.WriteLine($"number less than 6 : "));
        printNUm(l,n=>n>7,()=> Console.WriteLine($"number less than 7 : "));
        printNUm(l,n=>n%2==0,()=> Console.WriteLine($"even number : "));
        IEnumerable<decimal> l2 = new decimal[] { 1.3m, 3.1m, 1.4m, 2,3m, 5.21m, 6,43m, 7.43m, 8.5m, 9, 10, 11, 12, 13 };
        printNUm(l2, n => n > 5.2m,()=> Console.WriteLine("Number Greater than 5.2"));
    }
    static void printNUm<T>(IEnumerable<T>num,Func<T,bool> filter,Action action)//pointer
    {
        action();
        foreach (var item in num)
        {
            if (filter(item))
            {
                Console.WriteLine(item);
            }
        }
    }
}