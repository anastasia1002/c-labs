using System;

namespace lab10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Geompr a = new Geompr(7, 7, 20);
            //Console.Write("n=");
            //int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Bn={a.Bn()}");
            Console.WriteLine($"Sn={a.Sn()}");


           
            Console.WriteLine("");
            
        }
    }
}
