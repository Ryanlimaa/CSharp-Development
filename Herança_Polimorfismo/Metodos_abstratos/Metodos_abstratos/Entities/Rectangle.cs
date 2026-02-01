using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_abstratos.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; } // Largura
        public double Height { get; set; } // Altura

        public Rectangle(double width, double height, Color color)
            : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height; // Area de um retangulo
        }
    }
}
