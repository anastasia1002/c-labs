using System;

namespace lab6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());

            double [] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i+=2)
            {
                for (int j = 1; j < n; i+=2)
                {
                    if (i%2==0 && j%2!=0)
                    {
                        Console.WriteLine("list=",a[i]);
                    }
                }
            }
            Console.WriteLine();
                
                
        }
    }
}
