using System;

class Program
{
    /*
        Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.
        Entrada:
        O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).
        Saída:
        Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
    */
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int valor = n;

        int n100 = valor / 100;
        valor %= 100;

        int n50 = valor / 50;
        valor %= 50;

        int n20 = valor / 20;
        valor %= 20;

        int n10 = valor / 10;
        valor %= 10;

        int n5 = valor / 5;
        valor %= 5;

        int n2 = valor / 2;
        valor %= 2;

        int n1 = valor / 1;
        valor %= 1;

        System.Console.WriteLine(n);
        System.Console.WriteLine($"{n100} nota(s) de R$ 100,00");
        System.Console.WriteLine($"{n50} nota(s) de R$ 50,00");
        System.Console.WriteLine($"{n20} nota(s) de R$ 20,00");
        System.Console.WriteLine($"{n10} nota(s) de R$ 10,00");
        System.Console.WriteLine($"{n5} nota(s) de R$ 5,00");
        System.Console.WriteLine($"{n2} nota(s) de R$ 2,00");
        System.Console.WriteLine($"{n1} nota(s) de R$ 1,00");
    }
}