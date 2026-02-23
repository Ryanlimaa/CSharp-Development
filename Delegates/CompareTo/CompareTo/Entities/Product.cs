using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CompareTo.Entities
{
    internal class Product : IComparable<Product> // Implementando a interface IComparable para comparar objetos do tipo Product    
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(Product other) // Comparando um produto com outro produto
        {
            return Name.ToUpper().CompareTo(other.Name.ToUpper()); // Comparando os nomes dos produtos, convertendo para maiúsculo com ToUpper para evitar problemas de comparação  
        }
    }
}
