using System;
using System.Collections.Generic;
using System.Linq;  

namespace LINQ_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Especificar o data source (fonte de dados)
            int[] numeros = { 2, 3, 4, 5 };

            // Criar a consulta LINQ    
            var result = numeros
                .Where(x => x % 2 == 0) // Where é um método de extensão que filtra os elementos com base em uma condição (no caso pegando so os numeros pares)
                .Select(x => x * 10); // Select é um método de extensão que projeta cada elemento de uma sequência em uma nova forma (no caso multiplicando os numeros por 10)  

            // Executar a consulta e exibir os resultados   
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }  
    }
}
