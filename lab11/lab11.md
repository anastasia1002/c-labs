## Task1
__Описати клас, який містять вказані поля і методи. Клас “круг” – TCircle. ПОЛЯ:1. для зберігання радіуса;2. для зберігання центра кола__
__МЕТОДИ : 1.конструктор без параметрів, конструктор з параметрами, конструктор копіювання; 2.введення/виведення даних; 3.визначення площі круга; 4.перевірка належності точки кругу; 5.перевантаження операторів + (додавання радіусів), – (віднімання радіусів), *(множення радіуса на число).__
```cs
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

                Console.WriteLine("Write numer=");
                double numer = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"S={c.S()}");
                Console.WriteLine($"{c.Belong()}");

                Console.WriteLine($"Add :{c + numer}");
                Console.WriteLine($"Sub :{c - numer}");
                Console.WriteLine($"Mul :{c * numer}");
            }
            catch
            {
                Console.WriteLine("Number of point must be positive!!!");
            }
            

            


        }
    }
}
```
```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Circle
{
    class TCircle
    {
        public double r;
        public double x;
        public double y;
        
        public double R
        {
            get { return r; }
            set
            {
                if (value < 0)

                    throw new Exception("must be positive");
                r = value;
            }
        }
        public double X
        {
            get { return x; }
            set
            {
                if (value < 0)
                    throw new Exception("must be positive");
                x = value;
            }
        }
       public double Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                    throw new Exception("must be positive");
                y = value;
            }
        }
        public TCircle(double myR,double myX,double myY )
        {
            R = myR;
            X = myX;
            Y = myY;
        }
        public override string ToString()
        {
            return $"R={r},X={x},Y={y}";
        }
        public TCircle(TCircle b)
        {
            this.r = b.r;
            this.x = b.x;
            this.y = b.y;

        }
        public double S()
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        public bool Belong()
        {
            if( x<=r && y<= r)
                return true;
            else
                return false;

        }
        public static TCircle operator +(TCircle circle,double numer)
        {
            return new TCircle(circle.r + numer, circle.x + numer, circle.y + numer);
        }
        public static TCircle operator -(TCircle circle, double numer)
        {
            return new TCircle(circle.r - numer, circle.x - numer, circle.y - numer);
        }
        public static TCircle operator *(TCircle circle, double numer)
        {
            return new TCircle(circle.r * numer, circle.x * numer, circle.y * numer);
        }
    }
}
```
