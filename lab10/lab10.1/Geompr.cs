using System;
using System.Collections.Generic;
using System.Text;

namespace lab10._1
{
    class Geompr
    {
        private int b1;
        private double q;
        private int n;

        public int B1
        {
            get { return b1; }
            set
            {
                if (value == 0)
                    throw new Exception("first number musn`t =0");
                b1 = value;
            }
        }
        public double Q
        {
            get { return q; }
            set
            {
                if (value == 1)
                    throw new Exception("the denominator cannot be 1");
                q = value;
            }
        }
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public Geompr(int b1,double q,int n)
        {
            B1 = b1;
            Q = q;
            N = n;
        }
        public override string ToString()
        {
            return $"{b1},{q},{n}";
        }
        public double Bn()
        {
            return b1 * Math.Pow(q, n - 1);
        }
        public double Sn()
        {
            return (b1*(Math.Pow(q, n) - 1)) / q - 1;
        }


    }
}
