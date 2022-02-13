using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCalculator11
{
     public class Rectangle
    {
        private int lenght;
        private int width;

        public Rectangle()
        {
            lenght = 1;
            width = 1;
        }

        public int Length
        {
            set { lenght = value; }
            get { return lenght; }
        }


        public int Width
        {
            set { width = value; }
            get { return width; }
        }

        public int ValidRectangle(int width, int lenght)
        {
            return 2 * (width + lenght);
        }

        public int GetPerimeter(int width, int lenght)
        {
            return ((2 * width) + (2 * lenght));
        }

        public int GetArea(int width, int lenght)
        {
            return (width * lenght);
        }
    }
}
