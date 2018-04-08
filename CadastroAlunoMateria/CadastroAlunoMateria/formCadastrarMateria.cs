using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroAlunoMateria
{
    public partial class formCadastrarMateria : Form
    {
        formMainWindow main_window;

        public formCadastrarMateria(formMainWindow main_window)
        {
            InitializeComponent();
            this.main_window = main_window;
           
            foreach(String codigo in main_window.getCodigos())
            {
                this.comboMaterias.Items.Add(codigo);
            }
            this.comboMaterias.SelectedIndex = 0;
        }

        private void btnCancelarCad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.comboMaterias.SelectedIndex != -1)
            {
                this.main_window.cadastrarMateria(this.comboMaterias.SelectedIndex);
                this.main_window.atualizaCadastros();

            }
        }
    }
}
