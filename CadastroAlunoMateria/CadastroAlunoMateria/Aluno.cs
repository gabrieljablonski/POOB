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
        private HashSet<Materia> materias;

        public Aluno(String nome, String matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.materias = new HashSet<Materia>();
        }

        public void cadastrarMateria(Materia materia)
        {
            this.materias.Add(materia);
        }

        public void descadastrarMateria(int materia_n)
        {
            this.materias.Remove(this.materias.ElementAt(materia_n));
        }

        public String getNome()
        {
            return this.nome;
        }

        public String getMatricula()
        {
            return this.matricula;
        }

        public HashSet<Materia> getMaterias()
        {
            return this.materias;
        }
    }
}
