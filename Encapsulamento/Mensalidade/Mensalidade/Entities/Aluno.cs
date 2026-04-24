using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensalidade.Entities
{
    internal class Aluno
    {
        public int ID { get; set; } 
        public String Nome { get; set; }
        public int Idade { get; set; }
        public double Mensalidade { get; set; }

        public Aluno()
        {
        }

        public Aluno(int id, String nome, int idade, double mens)
        {
            ID = id;
            Nome = nome;
            Idade = idade;
            Mensalidade = mens;
        }

        public double CalcularMensalidade(double desconto)
        {
            return this.Mensalidade - (this.Mensalidade * desconto / 100);
        }

        public override string ToString()
        {
            return "ID: "
                + this.ID
                + "\nNome: "
                + this.Nome
                + "\nIdade: "   
                + this.Idade
                + "\nMensalidade: "
                + this.Mensalidade.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
