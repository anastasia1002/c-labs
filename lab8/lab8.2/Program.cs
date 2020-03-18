using System;

namespace lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("x_a=");
            double x_a = Convert.ToDouble(Console.ReadLine());
            Console.Write("y_a=");
            double y_a = Convert.ToDouble(Console.ReadLine());
            Console.Write("x_b=");
            double x_b = Convert.ToDouble(Console.ReadLine());
            Console.Write("y_b=");
            double y_b = Convert.ToDouble(Console.ReadLine());
            Console.Write("x_c=");
            double x_c = Convert.ToDouble(Console.ReadLine());
            Console.Write("y_c=");
            double y_c = Convert.ToDouble(Console.ReadLine());

            Console.Write("x_n=");
            double x_n = Convert.ToDouble(Console.ReadLine());
            Console.Write("y_n=");
            double y_n = Convert.ToDouble(Console.ReadLine());
            Console.Write("x_m=");
            double x_m = Convert.ToDouble(Console.ReadLine());
            Console.Write("y_m=");
            double y_m = Convert.ToDouble(Console.ReadLine());
            Console.Write("x_k=");
            double x_k = Convert.ToDouble(Console.ReadLine());
            Console.Write("y_k=");
            double y_k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Triangle(x_a, y_a, x_b, y_b, x_c, y_c, x_n, y_n, x_m, y_m, x_k, y_k));
            
            static double Triangle (double x1, double y1, double x2, double y2,double x3,double y3, double a1, double b1, double a2, double b2, double a3, double b3);
            {
                if (x1 < a1 && y1 < b1 && x2 < a2 && y2 < b2 && x3 < a3 && y3 < b3)
                    return "yes,these points belong to the triangle";
                else
                    return "noo,it's false";
            }
            

        }
    }
}
