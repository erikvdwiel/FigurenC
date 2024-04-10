using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren2
{
    internal class Circle : Figure
    {

        private int length;

 
        public Circle(int diameter, string color) : base(color)
        {
            Console.WriteLine("Cirkel wordt klaargemaakt en krijgt een diameter en een kleur");
            this.length = diameter;
        }

        public string Draw()
        {
            //Console.WriteLine("De cirkel wordt getekend");
            return "Dit is een object van de klas Circle, " + "de diameter van de circle is " + this.length + " en de kleur is " + this.getColor();
        }

    }
}
