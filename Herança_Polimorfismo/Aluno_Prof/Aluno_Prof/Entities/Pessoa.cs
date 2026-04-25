using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno_Prof.Entities
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual string ExibirDados()
        {
            return "Nome: "
                + Nome
                + "\nIdade: "
                + Idade;
        }
    }
}
