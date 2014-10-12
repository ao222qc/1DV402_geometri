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
            do
            {
                try  //Slänger in en try-catch för att hantera objektet som initieras och returneras i/från CreateShapemetoden. Presenterar felmeddelande.
                {
                    Console.Clear();
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
                            Console.WriteLine("\nPlease input a menu choice between 0-2 as specified above.\n");
                            Console.WriteLine("Enter any key to continue or ESCAPE to close the application.");
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
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        private static Shape CreateShape(ShapeType shapeType) //Tar emot argument i som bestämmer vilken "form" som skapas, läser även in längd/bredd och när
                                                              // objektet skapas skickas detta med till konstruktorn i klassen den skapas i (2 argument).
        {        
                double length = ReadDoubleGreaterThanZero("Input length.\n");
                double width = ReadDoubleGreaterThanZero("Input width.\n");

                if (shapeType == ShapeType.Ellipse)
                {
                    Ellipse ellipse = new Ellipse(length, width);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("=============");
                    Console.WriteLine("\nELLIPSE!\n");
                    Console.WriteLine("=============");
                    Console.ResetColor();
                    return ellipse;
                }
                if (shapeType == ShapeType.Rectangle)
                {
                    Rectangle rectangle = new Rectangle(length, width);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("=============");
                    Console.WriteLine("\nRECTANGLE!\n");
                    Console.WriteLine("=============");
                    Console.ResetColor();
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

                return input;            
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
        private static void ViewShapeDetail(Shape shape) //skriver ut datan ifrån ToStringmetoden i shape, där längd, bredd, area och omkrets "samlas".
        {
            Console.WriteLine("\n{0}\n", shape.ToString());
            Console.WriteLine("=====================================\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Press any key to continue, ESCAPE closes the application."); //Nu när main anropat alla metoder klart så kollar den efter en Key (do-while).
            Console.ResetColor();                                                           //Escape avslutar metoden, andra knappar gör att mainmetoden körs igen och börjar anrop, presentation igen etc.
        }
    }
}
