using System;

class Program
{
    static void Main(string[] args)
    {
        int soma1 = Somar(1, 2, 3);
        int soma2 = Somar(10, 20, 30);
        int soma3 = Somar(100, 200, 300);

        System.Console.WriteLine(soma1);
        System.Console.WriteLine(soma2);
        System.Console.WriteLine(soma3);
    }

    static int Somar(int a, int b, int c)
    {
        int resultado = a + b + c;
        return resultado;
    }
}
