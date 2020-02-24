using System;

namespace lab5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("epsilont=");
            double eps = Convert.ToDouble(Console.ReadLine());

            double sum = 0;
            double k = 1;
            double q = 1;

            while (Math.Sin(k*x)/k) > eps)
            {
                sum += q * Math.Sin(k * x) / k;
                k += 1;
                q *= -1;
            }
            Console.WriteLine("", sum, x, eps);
        }
    }
}
