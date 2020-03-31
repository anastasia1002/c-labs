using System;
using System.Collections.Generic;
using System.Text;

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
        public TCircle(double R)
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
