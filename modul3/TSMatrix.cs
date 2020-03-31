using System;
using System.Collections.Generic;
using System.Text;

namespace modul3
{
    class TSMatrix
    {
        public int row;
        
        public int[,] element;

        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        
        public TSMatrix(int row)
        {
            this.row = row;
            

            element = new int[row, row];
        }
        public void Vod()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write($"TSMatrix[{i},{j}]:");
                    int value = Convert.ToInt32(Console.ReadLine());
                    element[i, j] = value;
                }
            }
        }
         public void Vuvid()
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        Console.Write(element[i,j]);
                    }
                    Console.WriteLine();
                }
            }
            public TSMatrix(TSMatrix b)
            {
                this.row = b.row;
                
            }
        public override string ToString()
        {
            return $"Row={row}";
        }
        public int MyMax()
        {
            int max = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    int el = element[i, j];
                    if (el > max)
                        max = el;
                }
            }
            return max;
        }
        public int MyMin()
        {
            int min = element[0, 0];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    int el = element[i, j];
                    if (el < min)
                        min = el;
                }
            }
            return min;
        }
        public  double Sum()
        {
            double count = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    count += element[i, j];
                }
            }
            return count;
        }
        public static TSMatrix operator +(TSMatrix matr, int numer)
        {
            return new TSMatrix(matr.row + numer);
        }
        public static TSMatrix operator -(TSMatrix matr, int numer)
        {
            return new TSMatrix(matr.row - numer);
        }
        

    }

    }



