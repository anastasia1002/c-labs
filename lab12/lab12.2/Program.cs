using System;

namespace lab12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon p = new Polygon(5, 5);
            Console.WriteLine($"S={p.S()}");
            Console.WriteLine($"P={p.P()}");
        }
    }
}
