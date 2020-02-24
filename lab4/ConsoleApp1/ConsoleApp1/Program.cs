using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            double s = a * b;
            double p = 2 * (a + b);
            Console.WriteLine("S={0},P={1}", s, p);

        }
    }
}
