using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno_Prof.Entities
{
    internal class Aluno : Pessoa
    {
        public int RGM { get; set; }
        public string Curso { get; set; }
        public double Mensalidade { get; set; }

        public Aluno()
        {
        }

        public Aluno(string nome, int idade, int rgm, string curso, double mens) 
            : base(nome, idade)
        {
            RGM = rgm;
            Curso = curso;
            Mensalidade = mens;
        }

        public override string ExibirDados()
        {
            return "Nome: "
                + Nome
                + "\nIdade:"
                + Idade
                + "\nRGM: "
                + RGM
                + "\nCurso: "
                + Curso
                + "\nMensalidade: "
                + Mensalidade.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
