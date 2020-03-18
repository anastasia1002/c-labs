using System;

namespace lab8._3
{
    class Program
    {   
        static int Recursion(int i)
            {
                if (i == 0)
                    return 0;
                else if (i == 1 || i == 2)
                    return 9;
                else
                    return Recursion(i - 1) + Recursion(i - 2) + Recursion(i - 3);
            }
        static void Main(string[] args)
        {
            Console.Write("i=");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"i[{i}]={Recursion(i)}");
        }
    }
}
