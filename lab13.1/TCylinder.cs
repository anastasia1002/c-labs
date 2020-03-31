using System;
using System.Collections.Generic;
using System.Text;

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
