using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_H.P.Entities
{
    // Funcionarios tercerizados
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; } // Despesa adicional

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment() // Pagamento, reaproveitando o metodo da classe base com override e base
        {
            return base.Payment() + AdditionalCharge * 1.1; // Multiplicando a despesa adidional por 110%
        }
    }
}
