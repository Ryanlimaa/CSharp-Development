using System;
using System.IO;

namespace File_FileInfo
{
    public class  Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\C#\Arquivos\file1.txt.txt";
            string targetPath = @"c:\C#\Arquivos\file2.txt.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath); // Copiar arquivo
                Console.WriteLine("Arquivo copiado com sucesso!");

                string[] lines = File.ReadAllLines(sourcePath); // Ler todas as linhas do arquivo e guardar em um vetor
                foreach (string line in lines)
                {
                    Console.WriteLine(line); // Exibir o conteudo do vetor na tela
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}