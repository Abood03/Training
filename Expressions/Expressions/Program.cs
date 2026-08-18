using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        //primary Exp
        var amount = Math.Cos(30);
        Console.WriteLine(amount);
        //null 
        string s1 = null;// s1!="";
        //var s2 = s1.ToUpper();//NullReferenceException: 
        var s2 = s1?.ToUpper();
        Console.WriteLine(s2);

        s1 = s1 ?? "abood";
        Console.WriteLine(s1);
        s1 = s1 ?? "abood22";
        Console.WriteLine(s1);
        //switch 

        var amountJod = 100;
        var currType = "EUR";
        var output = 0d;
        var JODTOUSD = 1.41d;
        var JODTOEUR = 1.19d;
        var JODTOCAD = 1.78d;
        switch (currType) { 
            case "USD":
                output = amountJod * JODTOUSD;
                Console.WriteLine($"{amountJod} Jod = {output}");
                break;
            case "EUR":
                output= amountJod * JODTOEUR;
                Console.WriteLine($"{amountJod} Jod = {output}");

                break;
            case "CAD":
                output=amountJod * JODTOCAD;
                Console.WriteLine($"{amountJod} Jod = {output}");

                break;
            default:
                Console.WriteLine("unknown Currency type");
                break;
        }
        //switch 
        var cardNo = 13;
        string cardName = cardNo switch
        {
            1 => "ACE",
            13 => "KING",
            12 => "QUEEN",
            10 => "JACK",
            _ => cardNo.ToString()
        };
        Console.WriteLine(cardName);

        //iterations
        //fobonacci
        for (int i = 0, prev=0,current = 1; i < 10; ++i)
        {
            Console.Write(prev + " ");
            int newFib = prev + current;
            prev = current;
            current=newFib;
        }
        Console.WriteLine();
        var arr = new int[] { 1, 2, 3, 4 };
        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }
}