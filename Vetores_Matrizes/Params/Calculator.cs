using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Calculator
    {
        // usando o params para passar esse vetor como parametro para o class program
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        //MODIFICADORES DE PARAMETRO
        // usando o ref para referenciar um parametro na variavel original
        public static void Triples(ref int x)
        {
            x = x * 3;
        }

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
