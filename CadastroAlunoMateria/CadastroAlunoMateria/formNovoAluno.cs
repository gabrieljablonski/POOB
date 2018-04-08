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
    public partial class formNovoAluno : Form
    {
        private formMainWindow main_form;

        public formNovoAluno(formMainWindow main_form)
        {
            InitializeComponent();
            this.main_form = main_form;
        }

        private void NovoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
            if (this.txtANome.Text.Split()[0] != "")
            {
                main_form.adicionarAluno(this.txtANome.Text, (this.txtANum.Text!="")? this.txtANum.Text:"-");
                this.txtANome.Clear();
                this.txtANum.Clear();
            }

            this.txtANome.Focus();
        }
    }
}
