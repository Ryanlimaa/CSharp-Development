using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_abstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; } // Raio

        public Circle(double radius, Color color)
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius; // Area/Raio de um circulo
        }
    }
}
