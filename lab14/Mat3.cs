using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    class Mat3: TMatrix
    {
        Random rnd = new Random(DateTime.Now.Millisecond);
        public Mat3() : base(3, 3)
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
            return Matrix[0, 0] * Matrix[1, 1] * Matrix[2, 2] - Matrix[0, 0] * Matrix[2, 1] * Matrix[1, 2] + Matrix[0, 1] * Matrix[1, 2] * Matrix[2, 0] - Matrix[0, 1] * Matrix[2, 2] * Matrix[1, 0] + Matrix[0, 2] * Matrix[1, 0] * Matrix[2, 1] - Matrix[0, 2] * Matrix[2, 0] * Matrix[1, 1];
        }


        public override double SumOfMatrix()
        {
            double count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    count += Matrix[i, j];
                }
            }
            return count;
        }
    }
}
