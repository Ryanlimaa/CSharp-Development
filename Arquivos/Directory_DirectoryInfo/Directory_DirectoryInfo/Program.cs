using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_DirectoryInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\C#\Arquivos\myfolder";

            try
            {
                // Listar as pastas a partir de uma pasta path informada
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("PASTAS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                // Listar os arquivos a partir de uma pasta path informada
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("ARQUIVOS:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                // Criando uma pasta
                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occorred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
