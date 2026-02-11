using System;
using System.Collections.Generic;
using System.Globalization;

namespace HashSetExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de um HashSet para armazenar nomes únicos
            HashSet<string> nomes = new HashSet<string>();

            nomes.Add("Ana");
            nomes.Add("Bruno");
            nomes.Add("Carla");
            nomes.Add("Ana"); // Tentativa de adicionar um nome duplicado

            Console.WriteLine("Nomes no HashSet:");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            // Verificando se um nome existe no HashSet
            string nomeParaVerificar = "Bruno";
            if (nomes.Contains(nomeParaVerificar))
            {
                Console.WriteLine($"\nO nome '{nomeParaVerificar}' está presente no HashSet.");
            }
            else
            {
                Console.WriteLine($"\nO nome '{nomeParaVerificar}' não está presente no HashSet.");
            }

            // Removendo um nome do HashSet
            nomes.Remove("Carla");

            Console.WriteLine("\nNomes após remover 'Carla':");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}   