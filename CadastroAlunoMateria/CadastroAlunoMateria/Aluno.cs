using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadastroAlunoMateria
{
    class Aluno
    {
        private String nome;
        private String matricula;
        private HashSet<int> materias;

        public Aluno(String nome, String matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.materias = new HashSet<int>();
        }

        public void cadastrarMateria(int codigo_index)
        {
            this.materias.Add(codigo_index);
        }

        public void descadastrarMateria(int index)
        {
            if (index == -1) this.materias.Clear();
            else this.materias.Remove(index);
        }

        public String getNome()
        {
            return this.nome;
        }

        public String getMatricula()
        {
            return this.matricula;
        }

        public HashSet<int> getMaterias()
        {
            return this.materias;
        }
    }
}
