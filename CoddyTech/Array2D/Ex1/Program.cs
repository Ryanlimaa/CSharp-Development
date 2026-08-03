using System;

class Program
{

    /*
        Inicialize e imprima um array denteado (jagged array) com os seguintes valores:
        5, 7, 10, 24, 41
        86, 13, 683, 64, 13
        42, 46, 791, 111, 9
        86, 88, 1845, 5, 15897
        9, 1, 5, 5, 6
    */
    static void Main(string[] args)
    {
        int[][] matrix = new int[][]
        {
            new int[] {5, 7, 10, 24, 41},
            new int[] {86, 13, 683, 64, 13},
            new int[] {42, 46, 791, 111, 9},
            new int[] {86, 88, 1845, 5, 15897},
            new int[] {9, 1, 5, 5, 6}
        };

        System.Console.WriteLine();
        System.Console.WriteLine("---- MATRIZ RESULTADO ----");

        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[i].Length; j++)
            {
                System.Console.Write(matrix[i][j] + " ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}