using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace InterfacesExemplo.Entities
{
    internal class Invoice // Fatura
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice()
        {
        }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax;  }
        }

        public override string ToString()
        {
            return "Pagamento básico:" +
                BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nImposto: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento total: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
