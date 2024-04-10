using Figuren2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren2
{
    internal class Triangle : Figure
    {

        private int height;
        private int width;

        public Triangle(int height, int width, string color) : base(color) 
        {
            Console.WriteLine("Triangle wordt klaargemaakt en krijgt een hoogte, een breedte en een kleur");
            this.height = height;
            this.width = width;
        }

        public string Draw()
        {
            //Console.WriteLine("Een Triangle wordt getekend");
            return "Dit is een object van de klas Triangle, " + "de hoogte van de Triangle is " + this.height + ", de breedte is " + this.width + " en de kleur is " + this.getColor();
        }

    }
}
