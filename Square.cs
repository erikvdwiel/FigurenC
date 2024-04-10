using Figuren2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren2
{
    internal class Square : Figure
    {

        private int length;

        public Square(int length, string color) : base(color) 
        {
            Console.WriteLine("Square wordt klaargemaakt en krijgt een lengte en een kleur");
            this.length = length;
        }

        public string Draw()
        {
            //Console.WriteLine("Een Rechthoek wordt getekend");
            return "Dit is een object van de klas Square, " + "de lengte van de zijde is " + this.length + " en de kleur is " + this.getColor();
        }

    }
}
