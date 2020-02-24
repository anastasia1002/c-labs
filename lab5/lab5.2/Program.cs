using System;

namespace lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            
            int countZeroX = 0;
            int countZeroY = 0;
            int tempX = x;
            int tempY = y;
           
            while (x > 0)
            {
                if (x % 10 == 0)
                    countZeroX++;
                x /= 10;
            }
            while (y > 0)
            {
                if (y % 10 == 0)
                    countZeroY++;
                y /= 10;
            }
            if (countZeroX > countZeroY)
                Console.WriteLine("X містить більше 0");
            else if (countZeroX == countZeroY)
                Console.WriteLine("X і Y містять однакову кількість 0");
            else
                Console.WriteLine("Y містить більше 0");
        }
    }
}
