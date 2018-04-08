using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CadastroAlunoMateria
{
    public partial class formMainWindow : Form
    {
        private int alunos_cadastrados = 0;

        private List<Aluno> alunos = new List<Aluno>();

        public formMainWindow()
        {
            InitializeComponent();
        }

        // Methods
        public void adicionarAluno(String nome, String matricula)
        {
            this.dataGridAlunos.Rows.Add(++alunos_cadastrados, nome, matricula);
            this.dataGridAlunos.FirstDisplayedScrollingRowIndex = dataGridAlunos.RowCount - 1;
            this.alunos.Add(new Aluno(nome, matricula));
        }

        public void adicionarMateria(String codigo, String nome, String professor)
        {
            this.dataGridMaterias.Rows.Add(codigo, nome, professor);
            this.dataGridMaterias.FirstDisplayedScrollingRowIndex = dataGridMaterias.RowCount - 1;
        }

        public void cadastrarMateria(int codigo)
        {
            this.alunos[this.comboAlunos.SelectedIndex].cadastrarMateria(codigo);
        }

        public void atualizaCadastros()
        {
            this.dataGridRelatorio.Rows.Clear();
            HashSet<int> materias = this.alunos[this.comboAlunos.SelectedIndex].getMaterias();
            foreach (int materia_n in materias)
            {
                this.dataGridRelatorio.Rows.Add(this.dataGridMaterias[0, materia_n].Value, this.dataGridMaterias[1, materia_n].Value, this.dataGridMaterias[2, materia_n].Value);
            }
            if (dataGridRelatorio.RowCount != 0)
            {
                this.dataGridRelatorio.FirstDisplayedScrollingRowIndex = dataGridRelatorio.RowCount - 1;
            }

        }

        public List<String> getCodigos()
        {
            DataGridViewRowCollection rows = this.dataGridMaterias.Rows;
            List<String> codigos = new List<String>();
            for(int row_n=0; row_n < rows.Count; row_n++)
            {
                codigos.Add(rows[row_n].Cells[0].Value.ToString());
            }
            return codigos;
        }

        // Events
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageAluno_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            formNovoAluno novo_aluno = new formNovoAluno(this);
            novo_aluno.ShowDialog();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int selected = this.dataGridAlunos.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selected != -1)
            {
                this.dataGridAlunos.Rows.RemoveAt(selected);
                this.alunos.RemoveAt(selected);
                this.alunos_cadastrados--;
            }
            for(int i=0; i<this.dataGridAlunos.RowCount; i++)
            {
                this.dataGridAlunos[0, i].Value = i + 1;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionarMateria_Click(object sender, EventArgs e)
        {
            formNovaMateria nova_materia = new formNovaMateria(this);
            nova_materia.ShowDialog();
        }

        private void btnRemoverMateria_Click(object sender, EventArgs e)
        {
            int selected = this.dataGridMaterias.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selected != -1)
            {
                this.dataGridMaterias.Rows.RemoveAt(selected);
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            this.comboAlunos.Items.Clear();
            foreach(Aluno aluno in this.alunos)
            {
                this.comboAlunos.Items.Add(aluno.getNome());
            }
            if (this.comboAlunos.Items.Count != 0)
            {
                this.comboAlunos.SelectedIndex = 0;
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.comboAlunos.SelectedIndex != -1)
            {
                formCadastrarMateria cadastro = new formCadastrarMateria(this);
                cadastro.ShowDialog();
            }
            else
            {
                if (this.dataGridMaterias.RowCount == 0)
                {
                    MessageBox.Show("Registrar no mínimo uma matéria");
                }
                else
                {
                    MessageBox.Show("Selecionar aluno para cadastrar");
                }
            }
        }

        private void comboAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtRMat.Text = this.alunos[this.comboAlunos.SelectedIndex].getMatricula();
            this.atualizaCadastros();
        }

        private void btnRemoverCadastro_Click(object sender, EventArgs e)
        {
            int selected = this.dataGridRelatorio.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            this.alunos[this.comboAlunos.SelectedIndex].descadastrarMateria(selected);
            this.atualizaCadastros();
        }
    }
}
