namespace Portal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tituloForm = new Label();
            Nome = new Label();
            Idade = new Label();
            Curso = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtCurso = new TextBox();
            btnAdicionar = new Button();
            panel1 = new Panel();
            tituloPainel = new Label();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tituloForm
            // 
            tituloForm.AutoSize = true;
            tituloForm.BackColor = Color.Transparent;
            tituloForm.Font = new Font("Segoe UI", 16F);
            tituloForm.Location = new Point(80, 42);
            tituloForm.Name = "tituloForm";
            tituloForm.Size = new Size(118, 30);
            tituloForm.TabIndex = 0;
            tituloForm.Text = "Formulário";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.BackColor = Color.Transparent;
            Nome.Font = new Font("Segoe UI", 12F);
            Nome.Location = new Point(39, 102);
            Nome.Name = "Nome";
            Nome.Size = new Size(56, 21);
            Nome.TabIndex = 1;
            Nome.Text = "Nome:";
            // 
            // Idade
            // 
            Idade.AutoSize = true;
            Idade.BackColor = Color.Transparent;
            Idade.Font = new Font("Segoe UI", 12F);
            Idade.Location = new Point(39, 181);
            Idade.Name = "Idade";
            Idade.Size = new Size(51, 21);
            Idade.TabIndex = 2;
            Idade.Text = "Idade:";
            // 
            // Curso
            // 
            Curso.AutoSize = true;
            Curso.BackColor = Color.Transparent;
            Curso.Font = new Font("Segoe UI", 12F);
            Curso.Location = new Point(39, 255);
            Curso.Name = "Curso";
            Curso.Size = new Size(54, 21);
            Curso.TabIndex = 3;
            Curso.Text = "Curso:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(39, 126);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(211, 23);
            txtNome.TabIndex = 4;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(39, 205);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(211, 23);
            txtIdade.TabIndex = 5;
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(39, 279);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(211, 23);
            txtCurso.TabIndex = 6;
            txtCurso.TextChanged += txtCurso_TextChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(80, 329);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(121, 39);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tituloPainel);
            panel1.Controls.Add(listView);
            panel1.Location = new Point(331, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 415);
            panel1.TabIndex = 8;
            // 
            // tituloPainel
            // 
            tituloPainel.AutoSize = true;
            tituloPainel.BackColor = Color.Transparent;
            tituloPainel.Font = new Font("Segoe UI", 16F);
            tituloPainel.Location = new Point(15, 41);
            tituloPainel.Name = "tituloPainel";
            tituloPainel.Size = new Size(157, 30);
            tituloPainel.TabIndex = 9;
            tituloPainel.Text = "Lista de Alunos";
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView.Location = new Point(15, 101);
            listView.Name = "listView";
            listView.Size = new Size(381, 301);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Idade";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Curso";
            columnHeader3.Width = 160;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(739, 415);
            Controls.Add(panel1);
            Controls.Add(btnAdicionar);
            Controls.Add(txtCurso);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(Curso);
            Controls.Add(Idade);
            Controls.Add(Nome);
            Controls.Add(tituloForm);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloForm;
        private Label Nome;
        private Label Idade;
        private Label Curso;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtCurso;
        private Button btnAdicionar;
        private Panel panel1;
        private ListView listView;
        private Label tituloPainel;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
