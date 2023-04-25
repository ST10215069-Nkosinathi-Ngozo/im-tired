using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class circle : Shape
    {
        const double PI = 3.14;

        

        public double calcArea ()
        {
            double area = PI * getRadius() * getRadius();

            return area;
        }
    }
}
