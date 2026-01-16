using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Didite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua nacionalidade;");
        string nacionalidade = Console.ReadLine();

        Console.WriteLine("É graduado em economia?");
        bool economia = bool.Parse(Console.ReadLine());

        Console.WriteLine("É graduado em politicas publicas?");
        bool politicas = bool.Parse(Console.ReadLine());

        bool podeSeCandidatar = idade >= 30 && nacionalidade == "xurupitense" && (economia || politicas);

        Console.WriteLine("A pessoa pode se candidatar? " + podeSeCandidatar);
    }
}