using System;

class Program
{
    /*
        Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.
        Entrada:
        O arquivo de entrada contém um valor inteiro N.
        Saída:
        Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
    */
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int hora = n / (60 * 60);
        int resto = n % (60 * 60);

        int min = resto / 60;
        int sec = resto % 60;

        System.Console.WriteLine($"{hora}:{min}:{sec}");
    }
}