using System;

namespace lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            double current = 1;

            for (int i = 1; i <= n; i++)
            {
                current *= Math.Cos(x);
                sum += current;
            }
            Console.WriteLine("sum={0}", sum);
        }
    }
}
