using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometriskaFigurer
{
    class Program
    {
        static void Main(string[] args) //Kallar på ViewMenu för att visa menyn, tar in input och skapar object i CreateSHape beroende på input. 
                                        // Tar även hand om fel vid menyval genom en defaultcase där den presenterar ett felmed och går in i whiletrueloopen igen.
        {

            while (true)
            {  
                    try  //Slänger in en try-catch för att hantera objektet som initieras och returneras i/från CreateShapemetoden. Presenterar felmeddelande.
                    {
                        ViewMenu();
                        int input = int.Parse(Console.ReadLine());

                        switch (input)
                        {
                            case 0:
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\nPlease come again for all your calculatin' needs!\n");
                                Console.ResetColor();
                                return;
                            case 1:
                                ViewShapeDetail(CreateShape(ShapeType.Ellipse));//Anropar ViewShapeDetail (creatshape körs först och returnerar en referens till ett objekt,
                                break;                                          //vilket är referensen som skickas till ViewShapeDetail när datan ska presenteras.
                            case 2:
                                ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                                break;
                            default:
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Please input a menu choice between 0-2 as specified.");
                                Console.ResetColor();
                                break;
                        } 
                    }
                    catch (ArgumentException a)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n{0} ", a.Message);
                        Console.ResetColor();
                    }
            } 
        }

        private static Shape CreateShape(ShapeType shapeType) //Tar emot argument i som bestämmer vilken "form" som skapas, läser även in längd/bredd och när
                                                              // objektet skapas skickas detta med till konstruktorn i klassen den skapas i (2 argument).
        {
            
                double length = ReadDoubleGreaterThanZero("Input length.\n");
                double width = ReadDoubleGreaterThanZero("Input width.\n");

                    if (shapeType == ShapeType.Ellipse)
                    {
                        Ellipse ellipse = new Ellipse(length, width);
                        Console.WriteLine("\nELLIPSE!\n");
                        return ellipse;
                    }
                    if (shapeType == ShapeType.Rectangle)
                    {
                        Rectangle rectangle = new Rectangle(length, width);
                        Console.WriteLine("RECTANGLE!\n");
                        return rectangle;
                    }         
            return null;
        }

        private static double ReadDoubleGreaterThanZero(string prompt) //Skicka in en stringprompt för att skriva ut, returnerar ett flyttal vid anropet.
        {                                                              //Det returnerade värdet lagras i detta fall i t.ex (double length/width) i metoden CreateShape.
                                                                       //Tar även hand om felaktig input, om 
            while (true)
            {
                Console.Write(prompt);

               
                double input = double.Parse(Console.ReadLine());

                //if (input > 0)
                //{
                    return input;
                //}
                //else
                //{
                //    Console.BackgroundColor = ConsoleColor.DarkRed;
                //    Console.WriteLine("Error. Please enter a valid sum.\n");
                //    Console.ResetColor();
                //}
            }
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
            //Console.WriteLine("Press any key to continue, ESCAPE closes the application.");
        }


    }
}
