using System;
using System.Collections.Generic;
using System.Text;

namespace lab12._2
{
    class Polygon
    {
        private int side;
        private int n;

        public int Side
        {
            get { return side; }
            set
            {
                if (value < 0)
                    throw new Exception("the side cannot be negative");
                side = value;
            }
        }
        public int N
        {
            get { return n; }
            set
            {
                if (value < 0)
                    throw new Exception("the number cannot be negative");
                n = value;
            }
        }

        public Polygon(int side, int n)
        {
            Side = side;
            N = n;
        }
        public override string ToString()
        {
            return $"Side:{side},N:{n}";
        }

        public double S()
        {
            return 0.25 * N * Math.Pow(Side, 2) * 1 / Math.Tan(Math.PI / Side);
        }
        public double P()
        {
            return Side * N;
        }
    }
}
