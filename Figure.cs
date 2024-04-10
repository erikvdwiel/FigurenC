using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren2
{
    internal class Figure
    {

        private string color;

        public Figure(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return this.color;  
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public void Draw()
        {
            Console.WriteLine("Een figuur wordt getekend"); 
        }

    }
}
