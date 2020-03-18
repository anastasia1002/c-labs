## Task1
__Дано дійсні числа x,y,z . Обчислити:u= max(x,z) + max(x+y,xy)/max**2(x+y,xy)__
```cs
using System;

namespace lab8._1
{
    class Program
    {
        static int Max(int c1, int c2, int c3)
        {
            int m = c1;
            if (c2 > m)
                m = c2;
            if (c3 > m)
                m = c3;
            return m;
        }

        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y=");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z=");
            double z = Convert.ToDouble(Console.ReadLine());

            double max1 = Math.Max(x, z);
            double max2 = Math.Max(x + y, x * y);
            double max3 = Math.Pow(Math.Max(x + y, x * y), 2);

            double res = (max1 + max2) / max3;
            Console.WriteLine("result={0}", res);
        }
    }
}

```
## Task2
__Два трикутники задано координатами вершин. Використовуючи підпрограму визначення належності точки внутрішності трикутника, з’ясувати, чи лежить один з трикутників у середині іншого.__
```cs
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
```
## Task3
__Нехай x0=0, x1=x2=9, xi=xi-1 +xi-2 +xi-3. Визначити xn__
```cs
using System;

namespace lab8._3
{
    class Program
    {   
        static int Recursion(int i)
            {
                if (i == 0)
                    return 0;
                else if (i == 1 || i == 2)
                    return 9;
                else
                    return Recursion(i - 1) + Recursion(i - 2) + Recursion(i - 3);
            }
        static void Main(string[] args)
        {
            Console.Write("i=");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"i[{i}]={Recursion(i)}");
        }
    }
}
```
