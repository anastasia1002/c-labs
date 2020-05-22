using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab15._1
{
    class Percent : IInterestable
    {
        private double num;
        public double Num
        {
            get { return num; }
            set
            {
                if (value < 0)
                    throw new Exception("NOO");
                num = value;
            }
        }
        private double per;
        public double Per
        {
            get { return per; }
            set
            {
                if (value < 0)
                    throw new Exception("NOO");
                per = value;
            }
        }
        
        public Percent(double num,double per)
        {
            Num = num;
            Per = per;
        }
        public double PercentNum()
        {
            return (Num * Per) / 100;
        }
        public double IncreasingNum()
        {
            return Num + ((Num * Per) / 100);
        }
        public double DecreaseNum()
        {
            return Num - ((Num * Per) / 100);
        }

        
    }
}
