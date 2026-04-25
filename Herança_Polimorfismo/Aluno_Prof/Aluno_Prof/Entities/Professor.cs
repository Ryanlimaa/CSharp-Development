using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno_Prof.Entities
{
    internal class Professor : Pessoa
    {
        public string Especialidade { get; set; }   
        public int Num_aulas { get; set; }

        public Professor()
        {
        }

        public Professor(string nome, string especialidade, int aulas)
            : base(nome, 0)
        {
            Especialidade = especialidade;
            Num_aulas = aulas;
        }

        public override string ExibirDados()
        {
            return "Nome: "
                + Nome
                + "\nEspecialidade: "
                + Especialidade
                + "\nNumero de aulas no dia: "
                + Num_aulas;
        }
    }
}
