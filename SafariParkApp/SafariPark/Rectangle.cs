using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
   public sealed class Rectangle : Shape
    {
        public int _width;
        public int _height;
        public override int CalculateArea()
        {
            return _height * _width;
        }

        public Rectangle(int width, int height)
        {
            this._width = width;
            this._height = height;
        }
    }
}
