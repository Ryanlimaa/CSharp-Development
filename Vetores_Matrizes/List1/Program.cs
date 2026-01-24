using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria"); //Adicionar um dado a lista 
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");//Inserir uma dado informando a posição desejada

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);//Count informa o tamanho da lista 

            string s1 = list.Find(x => x[0] == 'A');//Forma resumida da função Test (expressão Lambda)
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Fist possition 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("-----------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);//Segunda lista com base na primeira para filtrar alguma informação (list.FindAll)
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------");

            list.Remove("Alex");//Remover um objeto da lista
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------");

            list.RemoveAll(x => x[0] == 'M');//Remover um objeto com uma condição da lista
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------");

            list.RemoveAt(0);//Remover um objeto da lista pela posição
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2);//Remover um objeto apartir da posição desejada
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }




            /*string s1 = list.Find(Test);//Afunção Find recebe como argumento uma função que faz um teste
            Console.WriteLine("First 'A': " + s1);*/

        }

        /*Função para Find
        static bool Test(string s)
        {
            return s[0] == 'A';
        }*/
    }
}