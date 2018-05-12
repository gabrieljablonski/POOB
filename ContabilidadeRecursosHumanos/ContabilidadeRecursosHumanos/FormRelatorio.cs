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
    public partial class FormRelatorio : Form
    {
        private FormMain formMain;
        public FormRelatorio(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void txtRelatorio_TextChanged(object sender, EventArgs e)
        {

        }

        public void imprimeRelatorio()
        {
            int i = 1;
            for(i = 0; i< this.formMain.numero_empregados; i++)
            {
                Empregado empregado = this.formMain.empregados[i];
                this.txtRelatorio.AppendText("Empregado " + (i+1) + ":\n\nNome: ");
                this.txtRelatorio.AppendText(empregado.getNome() + "\nCPF: " + empregado.getCPF() + "\n");
                this.txtRelatorio.AppendText("Endereço: " + empregado.getEndereco() + "\nSalário: " +
                                             empregado.salario().ToString("C") + "\n\n");
            }
        }
    }
}
