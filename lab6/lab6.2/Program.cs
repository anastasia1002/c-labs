using System;

namespace lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            double a_i = 0;
            double a_1 = -4;
            double a_2 = 3;
            double[] arr = new double[n];
            double sum = 0;
            double average;

            for (int i = 3; i <= n; i++)
            {
                a_i = Math.Pow(a_1, 2) + 2 * a_2 - i;
            }
            for (int i = 1; arr[i] < b && arr[i]>=c; i++)
            {
                sum += n;


            }
            average = sum / arr.Length;
            Console.WriteLine("average=", average);




        }
    }
}
