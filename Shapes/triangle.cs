using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class triangle : Shape
    {
        

        public double calcArea()
        {
            double area = .5 * getBase()  * getHeight();

            return area;
        }
    }
}

