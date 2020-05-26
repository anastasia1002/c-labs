using System;

namespace lab10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose unit: 1-byte, 2-kB, 3-MB, 4-GB");
            int unit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much memory do you want to compare?");
            double userMemory = Convert.ToDouble(Console.ReadLine());

            RAM m1 = new RAM("Producer1", new DateTime(2015, 12, 3), 2, 100);

            Console.WriteLine($"Convert Mb to Gb:{m1.ToGigabyte(m1.MemoryVolume)}"); 

            Console.WriteLine($"comparison of memory objects :{m1.ComapreMemory(unit, userMemory)}"); 
            Console.WriteLine($"number of years from production:{m1.Age()}");

        }
    }
}
