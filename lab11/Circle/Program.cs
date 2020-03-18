using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TCircle c=new TCircle(2,5,4);

                Console.WriteLine("Write numer=");
                double numer = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"S={c.S()}");
                Console.WriteLine($"{c.Belong()}");

                Console.WriteLine($"Add :{c + numer}");
                Console.WriteLine($"Sub :{c - numer}");
                Console.WriteLine($"Mul :{c * numer}");
            }
            catch
            {
                Console.WriteLine("Number of point must be positive!!!");
            }
            

            


        }
    }
}
