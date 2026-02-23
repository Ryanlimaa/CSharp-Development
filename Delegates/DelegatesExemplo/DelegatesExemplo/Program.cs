using DelegatesExemplo.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace DelegatesExemplo
{
    // Declarando um delegate que recebe dois double e retorna um double
    delegate double BinaryNumericOperation(double n1, double n2);

    // Declarando para um multicast delegate que recebe dois double e não retorna nada (void)
    delegate void BinaryNumericOperation2(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);
            Console.WriteLine(result);

            BinaryNumericOperation2 op2 = CalculationService.ShowSum;
            op2 += CalculationService.ShowMax;

            op2.Invoke(a, b);

            /*
            double result = CalculationService.Sum(a, b);
            Console.WriteLine(result);

            double result2 = CalculationService.Max(a, b);
            Console.WriteLine(result2);

            double result3 = CalculationService.Square(a);
            Console.WriteLine(result3);
            */
        }
    }
}   
