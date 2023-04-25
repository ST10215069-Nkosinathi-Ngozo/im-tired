using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Shape
    {
        double Base, Height, Radius;

        public Shape() {
            radius(10);
            shapeBase(20);
            height(30);
        }

        public void radius(double Radius)
        {
            this.Radius = Radius;
        }
        public void shapeBase(double Base)
        {
            this.Base = Base;
        }
        public void height(double Height)
        {
            this.Height = Height;
        }

        public double getHeight ()
        {
            return this.Height;
        }
        public double getBase()
        {
            return this.Base;
        }
        public double getRadius()
        {
            return this.Radius;
        }
    }
}

