using System;
using System.Globalization;

class Program
{
    /*
        Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais, segundo a fórmula:
        Distancia = {Distancia} = sqrt{(x_2 - x_1) * (x_2 - x_1) + (y_2 - y_1) * (y_2 - y_1)}
        Entrada:
        O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.
        Saída:
        Calcule e imprima o valor da distância segundo a fórmula fornecida, considerando 4 casas decimais.
    */
    static void Main(string[] args)
    {
        string[] entrada1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(entrada1[0], CultureInfo.InvariantCulture);
        double y1 = double.Parse(entrada1[1], CultureInfo.InvariantCulture);

        string[] entrada2 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(entrada2[0], CultureInfo.InvariantCulture);
        double y2 = double.Parse(entrada2[1], CultureInfo.InvariantCulture);

        double distancia = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

        System.Console.WriteLine(distancia.ToString("F4"), CultureInfo.InvariantCulture);
    }
}