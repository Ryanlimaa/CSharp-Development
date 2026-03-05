using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Lambda.Entities
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; } // Nivel da categoria (1, 2, 3, etc.) 
    }
}
