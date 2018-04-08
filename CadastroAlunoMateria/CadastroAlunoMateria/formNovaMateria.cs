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
    public partial class formNovaMateria : Form
    {
        private formMainWindow main_window;

        public formNovaMateria(formMainWindow main_window)
        {
            InitializeComponent();
            this.main_window = main_window;
        }

        private void NovaMateria_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.txtMCod.Text != "")
            {
                main_window.adicionarMateria(this.txtMCod.Text, (this.txtMNome.Text!="")? this.txtMNome.Text:"-", (this.txtMProf.Text!="")? this.txtMProf.Text:"-");
                this.txtMCod.Clear();
                this.txtMNome.Clear();
                this.txtMProf.Clear();
            }

            this.txtMCod.Focus();
        }
    }
}
