using System;
using System.Collections.Generic;
using System.Text;

namespace lab10._2
{
    class RAM
    {
        public string company_manufacturer;
        public int data;
        public double volume;
        public double cost;

        public string Company_manufacturer
        {
            get { return company_manufacturer; }
            set { company_manufacturer = value; }
        }
        public int Data
        {
            get { return data; }
            set
            {
                if (value < 0)
                    throw new Exception("data must be positive");
                data = value;
            }
        }
        public double Volume
        {
            get { return volume; }
            set
            {
                if (value < 0)
                    throw new Exception("value must be positive");
                volume = value;
            }
        }
        public double Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                    throw new Exception("cost must be positive");
                cost = value;
            }
        } 
        public RAM(string company_manufacturer,int data,double volume,double cost)
        {
            Company_manufacturer = company_manufacturer;
            Data = data;
            Volume = volume;
            Cost = cost;
        }
        public override string ToString()
        {
            return $"company_manufacturer={company_manufacturer}\r\ndata={data}\r\nvolume={volume}\r\ncost={cost}";
        }
        public double VolumeMbtoB()
        {
            return Math.Pow(volume, 6);
        }
        public double VolumeMbtoKB()
        {
            return Math.Pow(volume, 3);
        }
        public double VolumeMbto()
        {
            return Math.Pow(volume, -3);
        }
        public double Capacity()
        {

        }
    }
}
