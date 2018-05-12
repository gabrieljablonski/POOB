using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContabilidadeRecursosHumanos
{
    public partial class FormMain : Form
    {
        public Empregado[] empregados = new Empregado[10];
        public int numero_empregados = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadCLT_Click(object sender, EventArgs e)
        {
            FormCLT cad = new FormCLT(this);
            cad.Show();
        }

        public void inserirCLT(String nome, String cpf, String endereco, double sBruto)
        {
            EmpregadoCLT novo_empregado = new EmpregadoCLT();
            novo_empregado.inserirDadosCLT(nome, cpf, endereco, sBruto);

            this.empregados[numero_empregados++] = novo_empregado;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadH_Click(object sender, EventArgs e)
        {
            FormHorista cad = new FormHorista(this);
            cad.Show();

        }

        public void inserirHorista(String nome, String cpf, String endereco, int nHoras, double precoH)
        {
            EmpregadoHorista novo_empregado = new EmpregadoHorista();
            novo_empregado.inserirDadosHorista(nome, cpf, endereco, nHoras, precoH);

            this.empregados[numero_empregados++] = novo_empregado;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio rel = new FormRelatorio(this);
            rel.imprimeRelatorio();
            rel.Show();
        }
    }
}
