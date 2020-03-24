using System;

namespace practise1
{
    class Program
    {
        static double Formul(int i,int j,int n)
        {
            
            double a_ij;
            a_ij = j * Math.Cos(Math.Pow(i, 2) + n);
            return a_ij;
              
        }
        static void Main(string[] args)
        {
            Console.Write("k=");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("m=");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] A = new double[k, m];

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = Formul(i, j, n);
                        
                }
            }
            double sum = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i + j) % 2 == 1)
                        sum += A[i, j];

                }
            }
            Console.WriteLine("sum={0}",sum);
        }
    }
}
