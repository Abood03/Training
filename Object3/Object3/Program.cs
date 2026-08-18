public class Progeam
{
    static void Main(string[] args)
    {
        Demo d1=new Demo();
        //caller
        var a = 3;//ref
        int b;//out
        d1.aa(ref a);//8 is argument  // ref
        d1.cc(out b);//8 is argument  // ref
        Console.WriteLine(a);
        Console.WriteLine(b);
        int z = d1.bb();//primary exp
        Console.WriteLine(z);
        //////////////////
        var numStr = "12345e";
        int num;
        if (int.TryParse(numStr, out num))
        {
            Console.WriteLine(num);
            
        }
        else
            Console.WriteLine($"there is char {num}");

        d1.Promote(100, "balqa", "ddd");
        Demo.printEven(new []{3,3,4,1,4,1,4,1});
        Console.WriteLine();
        Console.ReadKey();

    }
    public class Demo
    {
        //Method Syntax
        public void aa(ref int a)//a is parmeter //ref
        {
            a = a * 2;
        }
        public void cc(out int a)//a is parmeter //ref
        {
            a = 2;
            a = a * 2;
        }
        public int bb()
        {
            int z = 3 * 9;
            return z;
        }


        // method signiture (Name +param Type + param order )
        //ovderloading methods (common way of polymorphism)
        public void Promote(double amount)
        {
            Console.WriteLine($"you got promotion of {amount}");
        }
        public void Promote(double amount ,string trip)
        {
            Console.WriteLine($"you got promotion {amount} and a trip {trip}");
        }
        public void Promote(double amount ,string trip,string hotel)
        {
            Console.WriteLine($"you got promotion {amount} and a trip {trip} and hotel {hotel}");

        }
        public static void printEven(int[] o)
        {
            foreach (var i in o)
            {
                if (isEven(i))
                {
                    Console.WriteLine(i);
                }
            }
            static bool isEven(int num)// local method 
            {
                return num % 2 == 0;
            }
        }
        //public bool isEven(int num) => num % 2 == 0;// other way to write method with one line
        
        



    }
}