using System;
using System.Collections.Generic;
using System.Text;

namespace lab12._1
{
    class TTime
    {
        private int minutes;
        private int hours;
        private int hv;
        private int hod;

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value < 0 && value>60)
                    throw new Exception("Minutes must be positive");
                minutes = value;
            }
        }
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value < 0)
                    throw new Exception("Hours must be positive");
                hours = value;
            }
        }
        public int Hv
        {
            get { return hv; }
            set
            {
                if (value < 0 && value<60)
                    throw new Exception("Numer must be positive");
                hv = value;
            }
        }
        public int Hod
        {
            get { return hod; }
            set
            {
                if (value < 0)
                    throw new Exception("Numer must be positive");
                hod = value;
            }
        }

        public TTime(int minutes, int hours,int hv,int hod)
        {
            Minutes = minutes;
            Hours = hours;
            Hv = hv;
            Hod = hod;

        }

        public int Multiply()
        {
            int S1 = (Hours * 60) + Minutes;
            int S2 = (Hod * 60) + Hv;
            int S3 = S1 + S2;
            return S3 / 60;
        }
        public int Reduction()
        {
            int S1 = (Hours * 60) + Minutes;
            int S2 = (Hod * 60) + Hv;
            int S3 = S1 - S2;
            return S3 / 60; 
        }
    }
}
