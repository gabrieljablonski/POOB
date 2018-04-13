using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CadastroAlunoMateria
{
    public partial class formMainWindow : Form
    {
        private int alunos_cadastrados = 0;

        private List<Aluno> alunos = new List<Aluno>();
        private List<Materia> materias = new List<Materia>();

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
            this.materias.Add(new Materia(codigo, nome, professor));
        }

        public void cadastrarMateria(int materia_n)
        {
            int selected = this.dataGridRelatorio.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            this.alunos[this.comboAlunos.SelectedIndex].cadastrarMateria(this.materias[materia_n]);
            this.atualizaCadastros();
        }

        public void atualizaCadastros()
        {
            this.dataGridRelatorio.Rows.Clear();
            HashSet<Materia> materias = this.alunos[this.comboAlunos.SelectedIndex].getMaterias();
            foreach (Materia materia in materias)
            {
                this.dataGridRelatorio.Rows.Add(materia.getCodigo(), materia.getNome(), materia.getProfessor());
            }
            if (dataGridRelatorio.RowCount != 0)
            {
                this.dataGridRelatorio.FirstDisplayedScrollingRowIndex = dataGridRelatorio.RowCount - 1; // Scroll to bottom
            }

        }

        public List<String> getCodigos()
        {
            List<String> codigos = new List<String>();
            
            foreach(Materia materia in this.materias)
            {
                codigos.Add(materia.getCodigo());
            }

            return codigos;
        }

        // Events
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionarMateria_Click(object sender, EventArgs e)
        {
            formNovaMateria nova_materia = new formNovaMateria(this);
            nova_materia.ShowDialog();
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
            if (selected != -1)
            {
                this.alunos[this.comboAlunos.SelectedIndex].descadastrarMateria(selected);
                this.atualizaCadastros();
            }
        }

        private void dataGridAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
