## Task1
__1. Описати клас, який містять вказані поля і методи. Клас “коло” – TCircle. ПОЛЯ :для зберігання радіуса. МЕТОДИ:1.конструктор без параметрів, конструктор з параметрами, конструктор копіювання; 2.введення/виведення даних; 3.визначення площі круга (обмеженого колом); 4.визначення довжини кола; 5.порівняння з іншим колом; 6.перевантаження операторів + (додавання радіусів), – (віднімання радіусів), * (множення радіуса на число).__
__2. Створити клас-нащадок TCylinder (циліндр) на основі класу TCircle. Додати метод знаходження об’єму циліндра та перевизначити відповідні методи.__
__3. Створити програму-клієнт для тестування.__
```cs
namespace lab13._1
{
    class TCircle
    {
        private protected double r;

        public double R
        {
            get { return r; }
            set
            {
                if (value < 0)
                    throw new Exception("R must be positive");
                r = value;
            }
        }
        public TCircle(double r)
        {
            R = r;
        }
        public override string ToString()
        {
            return $"R={r}";
        }
        public TCircle(TCircle b)
        {
            this.r = b.r;
        }
        public double S()
        {
            return r * Math.PI;
        }
        public double C()
        {
            return 2 * Math.PI * r;
        }
        public static bool operator ==(TCircle tc1, TCircle tc2)
        {
            return tc1.r == tc2.r;
        }
        public static bool operator !=(TCircle tc1, TCircle tc2)
        {
            return !(tc1 == tc2);
        }
        public static TCircle operator +(TCircle circle, double num)
        {
            return new TCircle(circle.r + num);
        }
        public static TCircle operator -(TCircle circle, double num)
        {
            return new TCircle(circle.r - num);
        }
        public static TCircle operator *(TCircle circle, double num)
        {
            return new TCircle(circle.r * num);
        }
    }
}
```

```cs
namespace lab13._1
{
    class TCylinder: TCircle
    {
        private double h;



        public double H
        {
            get { return h; }
            set
            {
                if (value < 0)
                    throw new Exception("H must be positive");
                h = value;
            }
        }
        public TCylinder(double r, double h) : base(r)
        {
            H = h;
        }
        public double V()
        {
            return Math.Pow(base.S(), 2) * h;
        }
        public new double S()
        {
            double sb = 2 * h * base.S();
            double so = 2 * Math.PI * Math.Pow(r, 2);
            return sb + so;
        }
        public override string ToString()
        {
            return $"R={r},H={h}";
        }
    }

}
```

```cs
namespace lab13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            TCircle tc1 = new TCircle(2);

            TCylinder tcy1 = new TCylinder(2, 10);
            Console.WriteLine("num=");
            double num = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"S={tc1.S()}");
            Console.WriteLine($"C={tc1.C()}");
            Console.WriteLine($"V={tcy1.V()}");

            Console.WriteLine($"Add :{tc1 + num}");
            Console.WriteLine($"Sub :{tc1 - num}");
            Console.WriteLine($"Mul :{tc1 * num}");
            }

            catch
            {
                Console.WriteLine("Number of point must be positive!!!");
            }
        }
    }
}
```