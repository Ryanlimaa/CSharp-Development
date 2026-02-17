using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExemplo.Entities
{
    internal class CarRental // Locação de carros
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public  Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental()
        {
        }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
