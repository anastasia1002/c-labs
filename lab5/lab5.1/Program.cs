using System;

namespace lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("натуральне число n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("дійсне число x= ");
            double x = Convert.ToDouble(Console.ReadLine());

            int sum = 0;
            int m = 1;
            int i = Math.Cos(double x);

            while (i<=Math.Pow((Math.Cos(double x),n))
            {
                sum += Math.Pow(Math.Cos(double x), m);
                m += 1;
            }
            else
            {
                sum = Math.Pow(Math.Cos(double x), n);
            }
            Console.WriteLine("вираз=", sum);
        }
    }
}
