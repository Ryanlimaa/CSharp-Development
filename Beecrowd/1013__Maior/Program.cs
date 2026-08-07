using System;

class Program
{
    /*
        Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula: maiorAB = {a + b + abs(a - b)}
        Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.
        Entrada:
        O arquivo de entrada contém três valores inteiros.
        Saída:
        Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
    */
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);
        int c = int.Parse(entrada[2]);

        int maiorAB = (a + b + Math.Abs(a - b)) / 2;

        int maiorFinal = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

        System.Console.WriteLine(maiorFinal + " eh o maior");
    }
}