using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometriskaFigurer
{
    class Ellipse : Shape //Ärver ifrån abstrakta Shape.
    {
        public override double Area
        {
            get
            {
                return Math.PI * (Length / 2) * (Width / 2); //returnerar Area till Shape (som man kan se i references)
            }
        }
        public override double Perimeter 
        {
            get 
            {
                return Math.PI * Math.Sqrt(2 * Length/2 * Length/2 + 2 * Width/2 * Width/2); //samma som Area
            }
        }
        public Ellipse(double length, double width) //Datan som tas emot när objekt av Ellipse instansieras. Skickas till Shape via :base, då den är basklassen för ellipse.
            :base(length, width)
        {
        }
    }
}
