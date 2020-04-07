using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    class Mat2: TMatrix
    {
        Random rnd = new Random(DateTime.Now.Millisecond);
        public Mat2() : base(2, 2)
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    Matrix[i, j] = rnd.Next(-10, 10);
                }
            }
        }
        public override double Det()
        {
            return Matrix[1, 0] * Matrix[0, 1] - Matrix[0, 0] * Matrix[1, 1];
        }
        public override double SumOfMatrix()
        {
            double count = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    count += Matrix[i, j];
                }
            }
            return count;
        }
    }
}
