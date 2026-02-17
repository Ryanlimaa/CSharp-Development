using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExemplo.Entities
{
    internal class Vehicle // Veiculo
    {
        public string Model { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
