using System;
using System.Collections.Generic;
using System.Globalization;

namespace SortedSetExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um SortedSet e adicionando elementos 
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);

            // Uniao
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); // Adicionando os elementos de b que nao exitem em c
            PrintCollection(c); 

            // Interseccao
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); // Mantendo apenas os elementos que existem nos dois conjuntos
            PrintCollection(d);

            // Diferenca 
            SortedSet<int> e = new SortedSet<int>(a);  
            e.ExceptWith(b); // Removendo os elementos de b que existem em a
            PrintCollection(e); 
        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}   
