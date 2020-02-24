using System;

namespace lab4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());

            if (Math.Pow(2*x,2)-x-3==0)
            {
                Console.WriteLine(1);
            }
            else if (Math.Pow(2 * x, 2) - x - 3 > 0)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(0);
            }

        }

    }
}
