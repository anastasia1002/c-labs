using System;

namespace lab7._6
{
    class Program
    {
        static int Neg(int[] vector)
        {
            int res = 0;
            for (int i = 0; i<vector.Length; i++)
			{
                if (vector[j] < 0)
                    res += 1;
			}
            return res;
        }
            
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m=");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n, m];
            int[] radk = new int[m];


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"A[{i},{j}]:");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    radk[j] = A[j, i]; 
                }
                if (Neg(radk) == 0)
                    Console.WriteLine($"sum={j + 1}={radk.Sum()}");
            }

        }
    }
}
