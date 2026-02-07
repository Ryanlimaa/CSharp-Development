using GenericsExemplo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace GenericsExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Deseja-se fazer um programa que leia um conjunto de N números inteiros (N de
            1 a 10), e depois imprima esses números de forma organizada conforme
            exemplo. Em seguida, informar qual foi o primeiro valor informado.*/

            PrintServiceT<string> printService = new PrintServiceT<string>();

            Console.Write("Quantos valores voce irá digitar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                printService.AddValue(value);
            }   

            printService.Print();
            Console.WriteLine("Primeiro valor: " + printService.First());   
        }
    }
}
