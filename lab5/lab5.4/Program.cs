using System;

namespace lab5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());

            int x0 = 0;
            int x1 = 7;
            int xn = 10;

            for (int i = 0; i < n-1; i++)
            {
                xn = x1 * (1 + x0);
                x0 = x1;
                x1 = xn;
            }
            Console.WriteLine("xn={0}", xn);
            
        }
    }
}
