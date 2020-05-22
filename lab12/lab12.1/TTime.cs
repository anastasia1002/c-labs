using System;
using System.Collections.Generic;
using System.Text;

namespace lab12._1
{
    class TTime
    {
        private int minutes;
        private int hours;
        

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
        

        public TTime(int minutes, int hours)
        {
            Minutes = minutes;
            Hours = hours;
            

        }
        public static TTime operator +(TTime time,int num)
        {
            return new TTime(time.hours + num, time.minutes + num);
        }
        public static TTime operator -(TTime time, int num)
        {
            return new TTime(time.hours - num, time.minutes - num);
        }

    }
}
