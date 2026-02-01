using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.VisualBasic;

namespace ex02_H.P.Entities
{
    // Produtos Usados
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; } // Data de fabricação

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (usado) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data de fabricação: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
