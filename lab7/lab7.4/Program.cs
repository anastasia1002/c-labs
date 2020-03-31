using System;

namespace lab7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m=");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"A[{i},{j}]");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int j = 0; j < a.GetLength(1); j++)
            {
                bool zamina;
                do
                {
                    zamina = false;
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        if (a[i-1,j]<a[i,j])
                        {
                            int t = a[i - 1, j];
                            a[i - 1, j] = a[i, j];
                            a[i, j] = t;
                            zamina = true; 
                            Console.WriteLine($"A[{i},{j}=a[i, j]");
                        }
                    }
                } while (zamina);
            }
           
        }
    }
}
