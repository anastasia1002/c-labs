using System;

namespace lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            double res = Math.Min(a, b) + Math.Pow(Math.Min(b, c),2) ;
            Console.WriteLine("result={0}", res);
        }
    }
}
