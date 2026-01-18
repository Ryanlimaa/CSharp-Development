using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex3_classes
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Construtor para a abrigatoriedade de informar os dados, iniciar valores dos atributos 
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Segundo construtor para deixar uma quantidade fixa
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 10;
        }
        // outra forma de instanciar produtos
        /*public Produto()
        {
        }
        */

        // : this() referenciar um construtor em outro
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int adicional)
        {
            Quantidade += adicional;
        }

        public void RemoverProdutos(int remover)
        {
            Quantidade -= remover;
        }


        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
