using System;

namespace CshrpPR1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int x2 = x * x;
            double y = x2 - 7 * x + 10;
            double y2 = x2 - 8 * x + 12;
            Console.WriteLine(y / y2);
        }
    }
}
