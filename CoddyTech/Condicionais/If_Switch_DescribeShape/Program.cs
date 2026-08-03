using System;

class Program
{
    /*
        Crie um método chamado DescribeShape que recebe um parâmetro inteiro representando o número de lados de uma figura, e retorna uma string descrevendo a figura de acordo com estas regras:
        3 lados: "Triangolo"
        4 lados: "Quadrilateral"
        5 lados: "Pentagono"
        6 lados: "Hexagono"
        Qualquer outro número de lados: "Polígono com {numero} lados"
        Implemente este método DUAS VEZES:
        Primeiro usando instruções if-else
        Depois usando uma instrução switch
        Ambas as implementações devem retornar os mesmos resultados.
    */
    static void Main(string[] args)
    {
        int lado = int.Parse(Console.ReadLine());

        System.Console.WriteLine($"Usando If: {DescribeShapeIf(lado)}");
        System.Console.WriteLine($"Usando Switch: {DescribeShapeSwitch(lado)}");
    }

    public static string DescribeShapeIf(int lado)
    {
        if(lado == 3)
        {
            return "Triangolo";
        }
        else if(lado == 4)
        {
            return "Quadrilateral";
        }
        else if(lado == 5)
        {
            return "Pentagono";
        }
        else if(lado == 6)
        {
            return "Hexagono";
        }
        else
        {
            return $"Polígono com {lado} lados";
        }
    }

    public static string DescribeShapeSwitch(int lado)
    {
        switch (lado)
        {
            case 3:
                return "Triangolo";
            case 4:
                return "Quadrilateral";
            case 5:
                return "Pentagono";
            case 6:
                return "Hexagono";
            default:
                return $"Polígono com {lado} lados";
        }
    }
}