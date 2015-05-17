using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework5
{
    abstract public class Shape
    {
        public int width { get; set; }
        public int heigth { get; set; }

        public Shape(int radius)
        {
            this.width = radius;
        }

        public Shape(int width, int heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }
        abstract public double CalculateSurface();
    }
}
