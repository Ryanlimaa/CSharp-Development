using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] grade = new int[5][];
        grade[0] = new int[] {1, 2, 3, 4};
        grade[1] = new int[] {1, 2, 3};
        grade[2] = new int[] {1, 2};
        grade[3] = new int[] {1};
        grade[4] = new int[4];

        grade[4][3] = 42; // na linha 4 e coluna 3 coloque '42'
        int valor = grade[0][1]; // pega o numero desse indice e salva nessa variavel

        System.Console.WriteLine();
        System.Console.WriteLine("---- MATRIZ RESULTADO ----");

        for(int i = 0; i < grade.Length; i++)
        {
            for(int j = 0; j < grade[i].Length; j++)
            {
                System.Console.Write(grade[i][j] + " ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine(valor);
        System.Console.WriteLine();
    }
}