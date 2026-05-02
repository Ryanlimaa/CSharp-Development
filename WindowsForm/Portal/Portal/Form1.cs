using Portal.Entities;
using System;   

namespace Portal
{
    public partial class Form1 : Form
    {
        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();    
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txtNome.Text;
                var idade = txtIdade.Text;
                var curso = txtCurso.Text;

                foreach(var item in Alunos)
                {
                    if(item.Nome == nome)
                    {
                        MessageBox.Show(nome + " já está cadastrado!");
                        return;
                    }
                }

                var aluno = new Aluno(nome, idade, curso);
                Alunos.Add(aluno);

                listView.Items.Add(new ListViewItem(new String[] { nome, idade, curso }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCurso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
