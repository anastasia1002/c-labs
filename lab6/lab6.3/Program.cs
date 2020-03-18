using System;

namespace lab6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[3];
            int[] vector2 = new int[3];

            for (int x = 0; x < 3; x++)
            {
                Console.Write("vector1 [{0}]=", x + 1);
                int v1 = Convert.ToInt32(Console.ReadLine());
                vector1[x] = v1;

            }
            for (int x = 0; x < 3; x++)
            {
                Console.Write("vector2[{0}]=", x + 1);
                int v2 = Convert.ToInt32(Console.ReadLine());
                vector2[x] = v2;
            }
            int res1 = vector1[0] * vector2[0];
            int res2 = vector1[1] * vector2[1];
            int res3 = vector1[2] * vector2[2];
            int res = res1 + res2 + res3;

            if (res == 0)
                Console.WriteLine("perpendicular");
            else
                Console.WriteLine("not");

            
        }
    }
}
