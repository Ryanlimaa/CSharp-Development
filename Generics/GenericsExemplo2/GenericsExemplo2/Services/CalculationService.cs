using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExemplo2.Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable // Metodo generico
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("A Lista não pode ser vazia!");
            }

            T max = list[0];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
