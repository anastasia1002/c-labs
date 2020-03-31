using System;
using System.Collections.Generic;
using System.Text;

namespace modul3
{
    class TDeterminant2 : TSMatrix
    {

        public TDeterminant2() : base(2) { }

        public double Det()
        {
            return element[0, 0] * element[1, 1] - element[0, 1] * element[1, 0];
        }






        //public new double Sum()
        //{
        //    double count = 0;
        //    for (int i = 0; i < 2; i++)
        //    {
        //        for (int j = 0; j < 2; j++)
        //        {
        //            count += element[i, j];
        //        }
        //    }
        //    return count;
    }

    }

