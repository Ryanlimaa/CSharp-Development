using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;    
using ExConjunto.Entities;

namespace ExConjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecords> set = new HashSet<LogRecords>();    

            Console.Write("Digite o caminho do arquivo: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecords { Username = name, Instant = instant });
                    }
                    Console.WriteLine("Total de usuarios: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}   
