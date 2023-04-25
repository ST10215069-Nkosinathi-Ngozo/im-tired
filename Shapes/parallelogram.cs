using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class parallelogram : Shape
    {
        public double calcArea()
        {
            double area = getHeight() * getBase();

            return area;
        }
    }
}

