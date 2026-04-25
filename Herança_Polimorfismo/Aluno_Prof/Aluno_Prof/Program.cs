using Aluno_Prof.Entities;
using System;   
using System.Collections.Generic;
using System.Globalization;

namespace Aluno_Prof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Professor prof = new Professor();

            Console.Write("Digite (a) para informações do aluno ou (p) para informações do professor: ");
            string escolha = Console.ReadLine()?.ToLower();

            while (escolha != "a" && escolha != "p")
            {
                Console.WriteLine("Opção inválida. Por favor, escolha 'a' para aluno ou 'p' para professor.");
                escolha = Console.ReadLine()?.ToLower();   
            }
            if (escolha == "a")
            {
                aluno.Nome = "Ryan Lima";
                aluno.Idade = 21;
                aluno.RGM = 123456;
                aluno.Curso = "Análise e Desenvolvimento de Sistemas";
                aluno.Mensalidade = 000.00;

                Console.WriteLine("\n" + aluno.ExibirDados());
            }
            else if (escolha == "p")
            {
                prof.Nome = "Maria Silva";
                prof.Idade = 35;
                prof.Especialidade = "Matemática";
                prof.Num_aulas = 5;

                Console.WriteLine("\n" + prof.ExibirDados());
            }
        }
    }
}
