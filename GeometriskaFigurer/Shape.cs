using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometriskaFigurer
{
    abstract class Shape
    {
       private double _length;
       private double _width;

       public abstract double Area
       {
           get;
       }
        public double Length
        {
            get { return _length; }
            set 
            {
                if (value <= 0)
                { throw new ArgumentException();}

                _length = value;
            }
        }
        public abstract double Perimeter
        {
            get;

        }
        public double Width
        {
            get { return _width; }

            set  
            {
                if (value <= 0)
                { throw new ArgumentException(); }
                _width = value;
            }
        }
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            StringBuilder hej = new StringBuilder();
            hej.AppendFormat("Length    : {0,5}\nWidth     : {1,5}\nPerimeter : {2,5:F1}\nArea      : {3,5:F1}",
                 Length, Width, Perimeter, Area);
            return hej.ToString();
        }




    }
    public enum ShapeType {Ellipse, Rectangle};
}
