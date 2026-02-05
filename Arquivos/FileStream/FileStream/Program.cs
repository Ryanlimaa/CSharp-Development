using System;
using System.IO;

namespace FileStreamExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\C#\Arquivos\file1.txt.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open); // Istanciando o FileStream passando ao arquivo e o modo que ele vai ser aberto
                sr = new StreamReader(fs); // Instanciando o StreamReader passando o FileStream crido a cima
                string line = sr.ReadLine(); // Lendo a primeira linha do arquivo
                string line2 = sr.ReadToEnd(); // Lendo o restante do arquivo
                Console.WriteLine(line);
                Console.WriteLine(line2);

                while (!sr.EndOfStream) // Metodo para ler o arquivo inteiro (enquanto nao chegar no final do arquivo, leia linha por linha )
                {
                    string line3 = sr.ReadLine();
                    Console.WriteLine(line3);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close(); // Fechando o bloco de codigo
                if (fs != null) fs.Close();
            }

            // Exemplo com using (faz o mesmo que o codigo a cima, porem com menos linhas e sem tratamento de excecao)
            /*using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }*/
        }
    }
}