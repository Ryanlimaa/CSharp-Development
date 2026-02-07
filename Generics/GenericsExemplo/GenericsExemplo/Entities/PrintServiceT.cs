using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExemplo.Entities
{
    internal class PrintServiceT<T> // Solução genérica    
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Capacidade maxima atingida!");
            }
            _values[_count] = value;
            _count++;
        }

        public T First()
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
