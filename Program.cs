using Figuren2;
using System.Drawing;

namespace Figuren2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start Programma");

            // Circle Circle1 = new Circle(50, "green");
            // Circle1.Draw();

            // Figure Figuur1 = new Figure("yellow");
            // string color = Figuur1.getColor();
            // Figuur1.Draw();

            // Console.WriteLine("De kleur van figuur1 is " + color);
            // Figuur1.setColor("red");
            // color = Figuur1.getColor();
            // Console.WriteLine("De kleur van figuur1 is " + color);

            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Blue;
            Circle Circle1 = new Circle(10, "Blue");
            string sTekstUitCircle = Circle1.Draw();
            Console.WriteLine(sTekstUitCircle);

            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            Square Square1 = new Square(13, "Red");
            string sTekstUitSquare = Square1.Draw();
            Console.WriteLine(sTekstUitSquare);

            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Triangle Triangle1 = new Triangle(9, 9, "Yellow");
            string sTekstUitTriangle = Triangle1.Draw();
            Console.WriteLine(sTekstUitTriangle);

            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Green;
            Rectangle Rectangle1 = new Rectangle(14, 8, "Green");
            string sTekstUitRectangle = Rectangle1.Draw();
            Console.WriteLine(sTekstUitRectangle);

            Console.ReadKey();  
        }
    }
}
