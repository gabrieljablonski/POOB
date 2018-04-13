using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadastroAlunoMateria
{
    class Materia
    {
        private String codigo;
        private String nome;
        private String professor;

        public Materia(String codigo, String nome, String professor)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.professor = professor;
        }

        public String getCodigo()
        {
            return this.codigo;
        }

        public String getNome()
        {
            return this.nome;
        }

        public String getProfessor()
        {
            return this.professor;
        }
    }
}
