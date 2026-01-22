using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Produto
    {
        // sintaxe do C# ao utilizar o "private": _nome
        private string _nome; // ATRUBUTOS PRIVATIVOS
        public double Preco { get; private set; } // PROPRIEDADES ALTOIMPLEMENTADAS
        private int _quantidade;

        // Construtor para a abrigatoriedade de informar os dados, iniciar valores dos atributos 
        public Produto(string nome, double preco, int quantidade) // CONSTRUTORES
        {
            _nome = nome;
            Preco = preco;
            _quantidade = quantidade;
        }

        // conceito de propeties, outra forma de encapsulamento(mais usada na linguagem C#) utilizando get e set
        public string Nome // PROPRIEDADES COSTUMIZADAS
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        /*public double Preco
        {
            get { return _preco; }
        }*/

        // obter Get
        /*public string GetNome()
        {
            return _nome;
        }

        // modificar/definir Set
        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }*/ 

        // OUTROS METODOS
        public double ValorTotalEmEstoque()
        {
            return Preco * _quantidade;
        }

        public void AdicionarProdutos(int adicional)
        {
            _quantidade += adicional;
        }

        public void RemoverProdutos(int remover)
        {
            _quantidade -= remover;
        }


        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
