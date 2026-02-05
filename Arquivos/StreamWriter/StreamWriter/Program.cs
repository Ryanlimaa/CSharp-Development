using System;
using System.IO;

namespace StreamWriterExemplo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\C#\Arquivos\file1.txt.txt";
            string targetPath = @"c:\C#\Arquivos\file2.txt.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occorred");
                Console.WriteLine(e.Message);
            }
        }
    }
}