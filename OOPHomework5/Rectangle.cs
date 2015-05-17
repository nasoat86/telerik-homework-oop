using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework5
{
    public class Rectangle : Shape
    {
        public Rectangle (int width, int heigth) : base (width, heigth)
        {
        }

        public override double CalculateSurface()
        {
            return this.heigth * this.width;
        }
    }
}
