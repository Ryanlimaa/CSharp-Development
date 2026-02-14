using System;
using System.Collections.Generic;
using System.Globalization;

namespace DictionaryExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "Ryan";
            cookies["email"] = "ryan@gmail.com";
            cookies["phone"] = "95109-7336";
            cookies["phone"] = "98478-9551";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("A chave 'email' não existe.");
            }

            Console.WriteLine("Tamanho: " + cookies.Count);

            Console.WriteLine("Todos os cookies");
            foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}