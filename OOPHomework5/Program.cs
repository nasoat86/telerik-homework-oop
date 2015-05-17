using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework5
{
    class Program
    {
        static void Main()
        {
            Shape[] shapes = { new Triangle(4, 5), new Rectangle(5, 7), new Circle(7) };

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i].CalculateSurface());
            }
        }
    }
}
