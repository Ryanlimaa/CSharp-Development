using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExemplo.Entities
{
    internal class PrintService
    {
        private int[] _values = new int[10]; // Criar um array para armazenar os valores
        private int _count = 0; // Contador para contar quantos valores foram adicionados

        public void AddValue(int value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Capacidade maxima atingida!");
            }
            _values[_count] = value; // Armazenar o valor no array
            _count++; // Incrementar o contador
        }

        public int First()
        {
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            Console.WriteLine("]");
        }
    }
}
