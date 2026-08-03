using System;

class Program
{
    /*
        Crie um método chamado MultipliqueMatriz que:
        Recebe duas matrizes (arrays denteados 2D) como parâmetros: matrix1 e matrix2
        As multiplica seguindo as regras de multiplicação de matrizes
        Retorna a matriz resultante

        Para que a multiplicação de matrizes seja válida:
        O número de colunas em matrix1 deve ser igual ao número de linhas em matrix2
        O resultado terá as dimensões: [matrix1.rows × matrix2.columns]
    */
    static void Main(string[] args)
    {
        int[][] matriz1 = new int[][]
        {
            new int[] {1, 4, 7},
            new int[] {2, 5, 8}
        };

        int[][] matriz2 = new int[][]
        {
            new int[] {1, 2},
            new int[] {3, 4},
            new int[] {5, 6}
        };

        int[][] result = MultipliqueMatriz(matriz1, matriz2);

        System.Console.WriteLine();
        System.Console.WriteLine("---- MATRIZ RESULTADO ----");

        foreach(var linha in result)
        {
            System.Console.WriteLine(String.Join(" ", linha));
        }
        System.Console.WriteLine();
    }

    public static int[][] MultipliqueMatriz(int[][] matriz1, int[][] matriz2)
    {
        int linhas = matriz1.Length;
        int colunas = matriz2[0].Length;
        int K = matriz1[0].Length;

        int[][] result = new int[linhas][];

        for(int i = 0; i < linhas; i++)
        {
            result[i] = new int[colunas]; // cada linha precisa ter o numero de colunas do resultado
            for(int j = 0; j < colunas; j++)
            {
                for(int k = 0; k < K; k++)
                {
                    result[i][j] += matriz1[i][k] * matriz2[k][j];
                }
            }
        }
        return result;
    }
}
