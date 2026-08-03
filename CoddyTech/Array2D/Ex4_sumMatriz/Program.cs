using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] matiz1 = new int[][]
        {
            new int[] {1, 1},
            new int[] {2, 2}
        };

        int[][] matriz2 = new int[][]
        {
            new int[] {3, 3},
            new int[] {4, 4}
        };

        int[][] result = SumMatriz(matiz1, matriz2);

        System.Console.WriteLine();
        System.Console.WriteLine("---- MATRIZ RESULTADO ----");

        foreach(var item in result)
        {
            System.Console.WriteLine(String.Join(" ", item));
        }
        System.Console.WriteLine();
    }

    public static int[][] SumMatriz(int[][] matriz1, int[][] matriz2)
    {
        int linha = matriz1.Length;

        int[][] result = new int[linha][];

        for(int i = 0; i < linha; i++)
        {
            result[i] = new int[matriz1[i].Length];
            for(int j = 0; j < matriz1[i].Length; j++)
            {
                result[i][j] = matriz1[i][j] + matriz2[i][j];
            }
        }
        return result;
    }
}
