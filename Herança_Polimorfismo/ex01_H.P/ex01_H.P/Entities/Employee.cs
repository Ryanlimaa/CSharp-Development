using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_H.P.Entities
{
    // Fincionarios
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; } // Horas trabalhadas
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment() // Pagamento, "virtual" para permitir override
        {
            return Hours * ValuePerHour;
        }
    }
}
