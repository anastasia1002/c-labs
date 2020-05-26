using System;
using System.Collections.Generic;
using System.Text;

namespace lab10._2
{
    class RAM
    {
        private string producer;
        private DateTime date;
        private double memoryVolume;
        private double price;

        public string Producer { get; set; }

        public DateTime Date { get; set; }

        public double MemoryVolume { get; set; }

        public double Price { get; set; }

        public RAM(string producer, DateTime date, double memoryVolume, double price)
        {
            Producer = producer;
            Date = date;
            MemoryVolume = memoryVolume;
            Price = price;
        }

        public double ToByte(double memory)
        {
            return memory * Math.Pow(1024, 2);
        }

        public double ToKilobyte(double memory)
        {
            return memory * 1024;
        }

        public double ToGigabyte(double memory)
        {
            return memory * Math.Pow(1024, -1);
        }

        public const double Epsilon = 4.94065645841247E-324;
        public bool ComapreMemory(int unit, double userMemory)
        {
            if (unit == 1) 
                return Math.Abs(this.ToByte(MemoryVolume) - userMemory) < Epsilon;
            if (unit == 2) 
                return Math.Abs(this.ToKilobyte(MemoryVolume)) - userMemory < Epsilon;
            if (unit == 3) 
                return Math.Abs(MemoryVolume - userMemory) < Epsilon;
            if (unit == 4)
                return Math.Abs(this.ToGigabyte(MemoryVolume) - userMemory) < Epsilon;
            return false;

        }

        public double Age() 
        {
            return DateTime.Now.Year - Date.Year;
        }
    }
}
