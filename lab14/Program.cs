using System;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            TMatrix m;
            Mat2 n = new Mat2();
            m = n;
            Console.WriteLine($"Sum 2={m.SumOfMatrix()}");
            Console.WriteLine($"Det 2={m.Det()}");

            Mat3 m3 = new Mat3();
            m = m3;
            Console.WriteLine($"Sum 3={m3.SumOfMatrix()}");
            Console.WriteLine($"Det 3={m3.Det()}");

        }
    }
}
