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
    public partial class FormCLT : Form
    {
        private FormMain formMain;
        public FormCLT(FormMain formMain)
        {
            this.formMain = formMain;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String nome = this.txtNome.Text;
            String cpf = this.txtCPF.Text;
            String endereco = this.txtEndereco.Text;
            double sBruto = Double.Parse(this.txtSalario.Text.Replace(".", ","));

            this.formMain.inserirCLT(nome, cpf, endereco, sBruto);

            this.Close();
        }
    }
}
