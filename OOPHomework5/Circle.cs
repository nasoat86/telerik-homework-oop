using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework5
{
    public class Circle : Shape
    {
        public Circle(int radius)
            : base(radius)
        {
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.width * 2;
        }
    }
}
