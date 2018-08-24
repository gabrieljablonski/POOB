using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        CriarArquivoTexto arquivo_texto;
        public Form1()
        {
            InitializeComponent();
            this.arquivo_texto = new CriarArquivoTexto("q4_p2.txt");
            this.arquivo_texto.abrirArquivo();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            RegistroAluno registro = new RegistroAluno();

            int matricula = int.Parse(this.txtMat.Text);
            string nome = this.txtNome.Text;
            string curso = this.txtCursoGrava.Text;

            registro.setMatricula(matricula);
            registro.setNome(nome);
            registro.setCurso(curso);

            if (this.arquivo_texto.adicionarRegistros(registro))
            {
                this.limparRegistro();
                this.btnPesquisar.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string curso = this.txtCursoPesquisar.Text;

            string registros = this.arquivo_texto.lerRegistros(curso);

            this.txtRegistros.Text = registros;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.limparPesquisa();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.arquivo_texto.fecharArquivo();
        }

        private void limparPesquisa()
        {
            this.txtCursoPesquisar.Clear();
            this.txtRegistros.Clear();
        }

        private void limparRegistro()
        {
            this.txtCursoGrava.Clear();
            this.txtMat.Clear();
            this.txtNome.Clear();
        }

    }
}
