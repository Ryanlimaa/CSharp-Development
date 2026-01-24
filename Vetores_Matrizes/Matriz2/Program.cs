using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[8, 8];

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (i == j)
                {
                    matriz[i, j] = 1;
                }
                else if (j == i)
                {
                    matriz[0, j] = 0;
                }
            }
        }

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                System.Console.Write(matriz[i, j]);
            }
            System.Console.WriteLine();
        }
    }
}

