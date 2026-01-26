using System;
using System.Globalization;

namespace Conndicional_ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura opcional ao if-else quando se deseja decidir um VALOR com base em uma condição.

            double preco = 34.5;
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            /*double preco = 34.5;
            double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }*/

        }
    }
}