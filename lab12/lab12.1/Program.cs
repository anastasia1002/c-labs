using System;

namespace lab12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            TTime t = new TTime(3, 60);
            Console.WriteLine("num=");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Add={t+num}");
            Console.WriteLine($"Sub={t-num}");

        }
    }
}
