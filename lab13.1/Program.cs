using System;

namespace lab13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            TCircle tc1 = new TCircle(2);

            TCylinder tcy1 = new TCylinder(2, 10);

            Console.WriteLine($"S={tc1.S()}");
            Console.WriteLine($"C={tc1.C()}");
            Console.WriteLine($"V={tcy1.V()}");

            Console.WriteLine($"Add :{tc1 + num}");
            Console.WriteLine($"Sub :{tc1 - num}");
            Console.WriteLine($"Mul :{tc1 * num}");
            }

            catch
            {
                Console.WriteLine("Number of point must be positive!!!");
            }
        }
    }
}
