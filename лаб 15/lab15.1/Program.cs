using System;

namespace lab15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Percent p1 = new Percent(2,5);
            Console.WriteLine($"Persent={ p1.PercentNum()}");
            Console.WriteLine($"Increasing={p1.IncreasingNum()}");
            Console.WriteLine($"Decrease={p1.DecreaseNum()}");
        }
    }
}
