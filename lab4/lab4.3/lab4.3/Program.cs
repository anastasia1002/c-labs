using System;

namespace lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1=");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2=");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1=");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2=");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z1=");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z2=");
            int z2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z2=");
            

            double a = Math.Sqrt(Math.Pow(y1 - x1, 2) + Math.Pow(y2 - x2, 2));
            double b = Math.Sqrt(Math.Pow(z1 - y1, 2) + Math.Pow(z2 - y2, 2));
            double c = Math.Sqrt(Math.Pow(z1 - x1, 2) + Math.Pow(z2 - x2, 2));

            double p = a + b + c;

            Console.WriteLine("P={0}", p);
        }
    }
}
