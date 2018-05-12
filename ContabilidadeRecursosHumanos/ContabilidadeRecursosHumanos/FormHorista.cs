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
    public partial class FormHorista : Form
    {
        private FormMain formMain;

        public FormHorista(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
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
            int nHoras = int.Parse(this.txtNHoras.Text);
            double precoHoras = Double.Parse(this.txtPrecoHora.Text.Replace(".", ","));

            this.formMain.inserirHorista(nome, cpf, endereco, nHoras, precoHoras);

            this.Close();
        }
    }
}
