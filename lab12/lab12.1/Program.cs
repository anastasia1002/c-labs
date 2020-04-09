using System;

namespace lab12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            TTime t = new TTime(2, 60, 2, 50);
            Console.WriteLine($"Add={t.Multiply()}minutes");
            Console.WriteLine($"Sub={t.Reduction()}minutes");
        }
    }
}
