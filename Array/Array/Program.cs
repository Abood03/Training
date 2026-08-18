using System.Security.Principal;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //single dim . Array 
            //Declaration
            var frinds = new string[5]
            { "1","2","3","4","5"};

            /*frinds[0] = "abood";
            frinds[1] = "2";
            frinds[2] = "3";
            frinds[3] = "4";
            frinds[4] = "5";*/

            var s = frinds[..2];//print first 2 el
            var s1 = frinds[2..3];//print  2 el
            var s3 = frinds[2..^2];//print last    2 el

            var item = frinds[5];
            Console.WriteLine(item);
            
            for (int i = 0; i < frinds.Length; i++)
            {
                Console.WriteLine(frinds[i]);
            }
            //multi din array
            int[,] _2darray = {
                { 1,3,5,2,4,},
                { 2,4,6,3,2,}
            };
            //jagged Array (array iside array)
            var jagged = new int[][]
            {
                new int []{ 1,2,3,},
                new int []{ 2,4,5,2,4,},
                new int []{ 3,4,6,2,4,}
            };

            //

        }

    }
}
