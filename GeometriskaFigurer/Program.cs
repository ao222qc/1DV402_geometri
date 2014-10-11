using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometriskaFigurer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                {
                    ViewMenu();
                    int input = int.Parse(Console.ReadLine());
                    if (input == 0)
                    {
                        return;
                    }
                    if (input == 1)
                    {
                        ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                        break;
                    }
                    if (input == 2)
                    {
                        ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nPlease enter a menu choice between 0-2.\n");
                        Console.ResetColor();
                    }

                }   
            }
        }
   
        private static Shape CreateShape(ShapeType shapeType)
        {

            double length = ReadDoubleGreaterThanZero("Input length.\n");
            double width = ReadDoubleGreaterThanZero("Input width.\n");
           
            if (shapeType == ShapeType.Ellipse)
            {
                Console.WriteLine("\nELLIPSE!\n");
                Ellipse ellipse = new Ellipse(length, width);
                return ellipse;
            }
            if (shapeType == ShapeType.Rectangle)
            {
                Console.WriteLine("RECTANGLE!\n");
                Rectangle rectangle = new Rectangle(length, width);
                return rectangle;  
            }
            return null;
        }

        private static double ReadDoubleGreaterThanZero(string prompt) 
        {

            while (true)
            {               
                    Console.Write(prompt);

                    double input = double.Parse(Console.ReadLine());

                    if (input > 0)
                    {
                        return input;
                    }         
                    else 
                    {
                     Console.BackgroundColor = ConsoleColor.DarkRed; 
                     Console.WriteLine("Error. Please enter a valid sum.\n");
                     Console.ResetColor();

                    }
            }

            //return input;
        }
        private static void ViewMenu()
        {
            Console.WriteLine("\nGeometrical figures.\n");
            Console.WriteLine("0: Cancel.\n");
            Console.WriteLine("1: Ellipse.\n");
            Console.WriteLine("2: Rectangle.\n");
            Console.WriteLine("\n=====================================\n");
            Console.Write("\nInput menu choice [0-2]: ");
        }
        private static void ViewShapeDetail(Shape shape)
        {
            Console.WriteLine("\n{0}\n", shape.ToString());
            Console.WriteLine("=====================================\n");
        }


    }
}
