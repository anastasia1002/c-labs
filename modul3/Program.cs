using System;

namespace modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                TSMatrix a = new TSMatrix(2);
                

                a.Vod();
                a.Vuvid();

                Console.WriteLine($"Max={a.MyMax()}");
                Console.WriteLine($"Min={a.MyMin()}");
                Console.WriteLine($"Sum={a.Sum()}");
                Console.WriteLine();

                Console.WriteLine("Write numer=");
                int numer = Convert.ToInt32(Console.ReadLine());
                TDeterminant2 d = new TDeterminant2();
                Console.WriteLine($"Det={d.Det()}");
                

                Console.WriteLine($"Add :{a + numer}");
                Console.WriteLine($"Sub :{a - numer}");

                
            }
            catch
            {
                Console.WriteLine("Number must be positive");
            }

            



        }
    }
}
