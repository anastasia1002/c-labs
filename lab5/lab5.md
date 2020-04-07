## Task1
__Дано натуральне число n і дійсне число x.Знайти cosx+cos**2...__
```cs
using System;

namespace lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            double current = 1;

            for (int i = 1; i <= n; i++)
            {
                current *= Math.Cos(x);
                sum += current;
            }
            Console.WriteLine("sum={0}", sum);
        }
    }
}
```
## Task2
__Дано два натуральних числа x і y. Знайти число, яке містить найбільшу кількість нулів.__
```cs
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
```
## Task3
__Перевірити справедливість рівності при заданій точності e:x=2(sinx-sin2x/2...)__
```cs

namespace lab5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("epsilont=");
            double eps = Convert.ToDouble(Console.ReadLine());

            double sum = 0;
            double k = 1;
            double q = 1;

            while (Math.Abs(Math.Sin(k)*x/k) > eps)
            {
                sum += q * Math.Sin(k )*x / k;
                k += 1;
                q *= -1;

            }
            Console.WriteLine($"sum={sum}");
        }
    }
}

```
## Task4
__Нехай x_0=0,x_1=7.Знайти x_i=x_i-1(1+x_i-2) де і=2,3...__
```cs 
using System;

namespace lab5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());

            int x0 = 0;
            int x1 = 7;
            int xn = 0;

            for (int i = 0; i < n-1; i++)
            {
                xn = x1 * (1 + x0);
                x0 = x1;
                x1 = xn;
            }
            Console.WriteLine("xn={0}", xn);
            
        }
    }
}

```

