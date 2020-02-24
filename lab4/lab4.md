## Task1
__Обчислити площу та периметр прямокутника, довжини сторін якого задаються.__
```cs
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            double s = a * b;
            double p = 2 * (a + b);
            Console.WriteLine("S={0},P={1}", s, p);

        }
    }
}

```

## Task2
__Дано три дійсних числа: a,b,c__

__Знайти min (a,b)+(min(b,c))**2__
```cs
using System;

namespace lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            double res = Math.Min(a, b) + Math.Pow(Math.Min(b, c),2) ;
            Console.WriteLine("result={0}", res);
        }
    }
}
```

## Task3
__Трикутник задається координатами своїх вершин на площині:A(x1,y1),B(x2,y2),C(x3,y3). Знайти периметр трикутника.__
```cs
using System;

namespace lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1=");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2=");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1=");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2=");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z1=");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z2=");
            int z2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z2=");
            

            double a = Math.Sqrt(Math.Pow(y1 - x1, 2) + Math.Pow(y2 - x2, 2));
            double b = Math.Sqrt(Math.Pow(z1 - y1, 2) + Math.Pow(z2 - y2, 2));
            double c = Math.Sqrt(Math.Pow(z1 - x1, 2) + Math.Pow(z2 - x2, 2));

            double p = a + b + c;

            Console.WriteLine("P={0}", p);
        }
    }
}
```

## Task4
__y=1,якщо 2x**2-x-3=0__
__y=2, якщо 2x**2-x-3>0__
__y=0, якщо 2x**2-x-3<0__
```cs
using System;

namespace lab4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());

            if (Math.Pow(2*x,2)-x-3==0)
            {
                Console.WriteLine(1);
            }
            else if (Math.Pow(2 * x, 2) - x - 3 > 0)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(0);
            }

        }

    }
}
```