using System;

class Program
{
    /*
        Crie um método chamado processMatrix que:
        Recebe um array irregular de inteiros (int[][] matrix) como parâmetro
        Retorna um novo array irregular onde:
        Cada elemento é substituído pela soma de seus elementos adjacentes (cima, baixo, esquerda, direita)
        Elementos nas bordas contam apenas os elementos adjacentes existentes
        A matriz original não deve ser modificada
    */
    static void Main(string[] args)
    {
        int[][] matriz = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };

        int[][] result = processMatrix(matriz);

        System.Console.WriteLine();
        System.Console.WriteLine("---- MATRIZ RESULTADO ----");

        foreach(var item in result)
        {
            System.Console.WriteLine(String.Join(" ", item));
        }
        System.Console.WriteLine();
    }

    public static int[][] processMatrix(int[][] matrix)
    {
        int rows = matrix.Length;
        int[][] result = new int[rows][];

        // 1. Instancia a nova matriz com as mesmas dimensões de cada linha
        for (int i = 0; i < rows; i++)
        {
            result[i] = new int[matrix[i].Length];
        }

        // 2. Percorre cada elemento para calcular a soma dos vizinhos
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                int sum = 0;

                // Checa Vizinho de CIMA (linha i - 1)
                if (i > 0 && j < matrix[i - 1].Length)
                {
                    sum += matrix[i - 1][j];
                }

                // Checa Vizinho de BAIXO (linha i + 1)
                if (i + 1 < rows && j < matrix[i + 1].Length)
                {
                    sum += matrix[i + 1][j];
                }

                // Checa Vizinho da ESQUERDA (coluna j - 1)
                if (j > 0)
                {
                    sum += matrix[i][j - 1];
                }

                // Checa Vizinho da DIREITA (coluna j + 1)
                if (j + 1 < matrix[i].Length)
                {
                    sum += matrix[i][j + 1];
                }

                result[i][j] = sum;
            }
        }

        return result;
    }
}
