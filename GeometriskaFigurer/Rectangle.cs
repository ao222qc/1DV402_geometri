using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometriskaFigurer
{
    class Rectangle : Shape
    {
        public override double Area
        {
            get 
            {
                return Length * Width;              
            }
        }
        public override double Perimeter
        {
            get
            {
                return 2 * Length + 2 * Width;
            }
        }
        public Rectangle(double length, double width)
            : base(length, width)
        {
            //Tom konstruktor som tar emot argument, fixar in dem till basklassens konstruktor med :base(length,width).
        }

    }
}
