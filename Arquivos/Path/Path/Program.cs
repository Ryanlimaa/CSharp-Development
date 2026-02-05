using System;
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("Caracter de separação: " + Path.DirectorySeparatorChar);
            Console.WriteLine("Caracter para separar pastas: " + Path.PathSeparator);
            Console.WriteLine("Nome do caminho da pasta: " + Path.GetDirectoryName(path));
            Console.WriteLine("Nome do arquivo: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}