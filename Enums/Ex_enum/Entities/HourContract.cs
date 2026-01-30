using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_enum.Entities
{
    internal class HourContract //tempo de contrato
    {
       
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; } //Valor por hora
        public int Hours { get; set; } //Duração do contrato

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
