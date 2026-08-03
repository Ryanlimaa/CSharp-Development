using System;

class Program
{
    /*
        Crie um método chamado ConverteParaInt que:
        Receba uma nota em letra como um parâmetro de string
        Converta-a para um ponto de nota numérico usando as abordagens switch e if-else
        O método deve implementar ambas as abordagens e retornar o resultado da implementação switch
        Use estas conversões de notas:
        "A" ou "a" = 4
        "B" ou "b" = 3
        "C" ou "c" = 2
        "D" ou "d" = 1
        "F" ou "f" = 0
        Qualquer outra entrada = -1
    */
    static void Main(string[] args)
    {
        string nota = Console.ReadLine();

        System.Console.WriteLine($"Nota = {ConverteParaInt(nota)}");
    }

    public static int ConverteParaInt(string nota)
    {
        switch (nota)
        {
            case "A":
            case "a":
                return 4; 
            case "B":
            case "b":
                return 3;
            case "C":
            case "c":
                return 2;
            case "D":
            case "d":
                return 1;
            case "F":
            case "f":
                return 0;
            default:
                return -1;
        }
    }
}
