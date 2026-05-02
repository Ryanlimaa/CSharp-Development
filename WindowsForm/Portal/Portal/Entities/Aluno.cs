using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Entities
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Curso { get; private set; }  
        
        public Aluno(string nome, string idade, string curso)
        {
            if(string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome é obrigatório!");
            }

            if(string.IsNullOrEmpty(idade))
            {
                throw new Exception("Idade é obrigatória!"); 
            }

            if(string.IsNullOrEmpty(curso))
            {
                throw new Exception("Curso é obrigatório!");    
            }

            Nome = nome;
            Idade = int.Parse(idade);
            Curso = curso;
        }
    }
}
