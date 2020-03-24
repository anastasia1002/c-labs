using System;

namespace lab7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] A = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("A[{0},{1}]", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == j)
                        Console.WriteLine("A[{0},{1}]={2}", i, j, A[i, j]);
                    else
                        Console.WriteLine("error");
                }
            }
        }
    }
}
