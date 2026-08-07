using System;
using System.Globalization;

class Program
{
    /*
        Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
        a) a área do triângulo retângulo que tem A por base e C por altura.
        b) a área do círculo de raio C. (pi = 3.14159)
        c) a área do trapézio que tem A e B por bases e C por altura.
        d) a área do quadrado que tem lado B.
        e) a área do retângulo que tem lados A e B.
        Entrada:
        O arquivo de entrada contém três valores com um dígito após o ponto decimal.
        Saída:
        O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.
    */
    static void Main(string[] args)
    {
        double pi = 3.14159;
        string[] valores = Console.ReadLine().Split(' ');
        double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

        double triangulo = (a * c) / 2.0;
        double circulo = pi * c * c;
        double trapezio = ((a + b) * c) / 2.0;
        double quadrado = b * b;
        double retangulo = a * b;

        System.Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}