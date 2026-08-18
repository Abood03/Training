class Program
{
    static void Main(string[] args)
    {
        //string interpolation
        string s1 = "abood";
        string s2 = "alabadi";
        string s3 = $"{s1} {s2}";
        Console.WriteLine(s3);
        //
        Console.WriteLine($"int [{int.MaxValue}→ {int.MinValue}]");
        //var
        var s4 = "abood";//string
        var d1 = 32d;//double
        var m1 = 23m;//decimal
        var u = 21u;//int
        var l = 3l;//long
        var million = 1_000_000;
        //dynamic
        dynamic d = 123;
        d = "abood";

        //char
        char latter = 'c';

        var name = "abdullah"; 
        var id = 1;
        var salary = 500d;
        var gender = 'M';
        Console.WriteLine($"ID: {id} name: {name} salary: {salary} Gender: {gender}");

        //returnerty oppratino
        var x1 = 300;
        var x2 = 500;
        var eq=x1>=x2 ?true:false;
        Console.WriteLine(eq);






    }
}

