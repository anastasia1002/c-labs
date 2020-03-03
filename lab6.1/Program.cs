using System;

namespace lab6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("size=");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[size];
            int count = 0;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            for (int i = 0; i < size-2; i++)
            {
                num1 = num[i];
                num2 = num[i + 1];
                num3 = num[i + 2];
                Console.Write("[{0}] = ", i);
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            if ((num1+num3)/2==num2)
            {
                count += 1;
            }
            Console.WriteLine("{0}", count);
        }
    }
}
