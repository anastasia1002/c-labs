using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    public abstract class TMatrix
    {
        public double this[int row, int coll]
        {
            get
            {
                if (row >= 0 && coll >= 0)
                {
                    return this[row, coll];
                }
                else
                    throw new Exception("noo");

            }
            set
            {
                if (row >= 0 && coll >= 0)
                {
                    this[row, coll] = value;
                }
                else
                    throw new Exception("noo");
            }
        }
        public int Row { get; set; }
        public int Col { get; set; }
        public double[,] Matrix;
        public TMatrix(int row, int col)
        {
            Col = col;
            Row = row;
            Matrix = new double[Row, Col];
        }
        public abstract double SumOfMatrix();
        public abstract double Det();
        public void show()
        {
            Console.WriteLine($"Sum = {SumOfMatrix()} , Det = {Det()}");
        }

    }
}
