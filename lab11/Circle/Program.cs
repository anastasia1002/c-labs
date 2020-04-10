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
                TCircle c1 = new TCircle(2, 5, 4);


                Console.WriteLine($"S={c.S()}");
                Console.WriteLine($"{c.Belong()}");

                Console.WriteLine($"Add :{c + c1}");
                Console.WriteLine($"Sub :{c - c1}");
                Console.WriteLine($"Mul :{c * c1}");
            }
            catch
            {
                Console.WriteLine("Number of point must be positive!!!");
            }
            

            


        }
    }
}
