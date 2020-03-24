using System;

namespace lab7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m=");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[n, m];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("A[{0},{1}]", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] *= a;
                    Console.WriteLine("A[{0},{1}]={2}", i, j, A[i, j]);
                }
            }

        }
    }
}
