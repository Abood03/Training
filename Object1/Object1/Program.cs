class Program
{
    static void Main(string[] args)
    {
        //object\
        Int16 s;//short
        Int32 x;//int
        Int64 l;//long
        var num = 10;
        string str = num.ToString();
        int a =int.Parse( str);
        //boxing ,unBoxing
        int z = 10;
        object obj;
        obj = z;//boxing
        int y = (int)obj;//unboxing
    }
}