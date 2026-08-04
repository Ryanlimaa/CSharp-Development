using System;
using System.Globalization;

class Program
{
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