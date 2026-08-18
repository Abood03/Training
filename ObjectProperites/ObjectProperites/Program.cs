using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        var ip = new IP(158, 61, 10, 1);
        var ip1 = new IP("158", "70", "10", "1");
        var ip2 = new IP("192.168.1.1");

        Console.WriteLine(ip.Address);
        Console.WriteLine(ip1.Address);
        Console.WriteLine(ip2.Address);
        var firstsegment = ip[0];
        Console.WriteLine(firstsegment);
    }
     public class IP
    {
        private int[] segment = new int[4];

        public int this[int index]
        {
            get { return segment[index]; }
            set { segment[index] = value; }
        }
        public IP(string segment1 ,string segment2,string segment3 ,string segment4)
        {
            segment[0] = int.Parse(segment1);
            segment[1] = int.Parse(segment2);
            segment[2] = int.Parse(segment3);
            segment[3] = int.Parse(segment4);
        }
        public IP (string IPAddrees)
        {
            var seg = IPAddrees.Split(".");
            for (int i = 0; i < seg.Length; i++)
            {
                segment[i] = int.Parse(seg[i]);


            }
        }

        public IP(int segment1 ,int segment2 , int segment3 ,int segment4 )
        {
            segment[0]=segment1;
            segment[1]=segment2;
            segment[2]=segment3;
            segment[3]=segment4;
        }

        public string Address => string.Join(".", segment);
    }
}