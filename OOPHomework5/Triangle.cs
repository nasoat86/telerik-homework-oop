using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework5
{
    public class Triangle : Shape
    {
        public Triangle(int heigth, int width)
            : base(heigth, width)
        {
        }

        public override double CalculateSurface()
        {
            return this.heigth * this.width / 2; 
        }
    }
}
