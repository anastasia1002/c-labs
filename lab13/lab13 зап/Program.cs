using System;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            TCircle tc1 = new TCircle(66);

            TCylinder tcy1 = new TCylinder(66, 10);

            Console.WriteLine($"S={tc1.S()}");
            Console.WriteLine($"C={tc1.C()}");
            Console.WriteLine($"V={tcy1.V()}");
        }
    }
}
