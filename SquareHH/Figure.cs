using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareHH
{
    public class Figure
    {
        // Радиус.
        double r { get; set; }
        // Размеры сторон.
        List<double> sideLen { get; set; }

        // Инициализация круга.
        public Figure(double r)
        {
            this.r = r;
            sideLen = new List<double>();
        }

        // Инициализация многоугольника.
        public Figure(double[] sideLen)
        {
            this.sideLen = sideLen.ToList();
            this.sideLen.Sort();
        }

        public bool IsRectangular()
        {
            if (sideLen.Count != 3)
                throw new Exception("Не треугольник");
            if (sideLen[0] * sideLen[0] + sideLen[1] * sideLen[1] == sideLen[2] * sideLen[2])
                return true;
            return false;
        }

        public double Square()
        {
            if (sideLen.Count() == 0)
                return Math.PI * r * r;
            switch (sideLen.Count)
            {
                case 3: 
                    double p = sideLen.Sum() / 2;
                    return Math.Sqrt(p * (p - sideLen[0]) * (p - sideLen[1]) * (p - sideLen[2]));
                default:
                    throw new Exception("Неверные данные");
            }
        }

    }
}
