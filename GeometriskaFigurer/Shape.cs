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
                { throw new ArgumentException("The number(s) entered cannot be calculated. Please enter a value bigger than 0."); } //När datan skickas hit ifrån Ellipse/Rectangle kollas den innan
                _length = value;                                                                       // den tillskrivs fälten. Kastar undantag om värdet är för litet.
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
                { throw new ArgumentException("The number(s) entered cannot be calculated. Please enter a value bigger than 0."); }
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
                 _length, _width, Perimeter, Area);
            return hej.ToString();
        }




    }
    public enum ShapeType {Ellipse, Rectangle}
}
