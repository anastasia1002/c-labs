using System;

namespace lab8._1
{
    class Program
    {
        static int Max(int c1, int c2, int c3)
        {
            int m = c1;
            if (c2 > m)
                m = c2;
            if (c3 > m)
                m = c3;
            return m;
        }

        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y=");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z=");
            double z = Convert.ToDouble(Console.ReadLine());

            double max1 = Math.Max(x, z);
            double max2 = Math.Max(x + y, x * y);
            double max3 = Math.Pow(Math.Max(x + y, x * y), 2);

            double res = (max1 + max2) / max3;
            Console.WriteLine("result={0}", res);
        }
    }
}
