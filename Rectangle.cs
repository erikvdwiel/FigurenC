using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren2
{
    internal class Rectangle : Figure
    {

        private int height;
        private int width;

        public Rectangle(int height, int width, string color) : base(color)
        {
            Console.WriteLine("Rectangle wordt klaargemaakt en krijgt een hoogte, een breedte en een kleur");
            this.height = height;
            this.width = width;

        }

        public string Draw()
        {
            //Console.WriteLine("Een Rectangle wordt getekend");
            return "Dit is een object van de klas Rectangle, " + "de hoogte van de Rectangle is " + this.height + ", de breedte is " + this.width + " en de kleur is " + this.getColor();
        }

    }
}
