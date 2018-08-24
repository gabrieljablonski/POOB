using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q4
{
    public class RegistroAluno
    {
        private int matricula;
        private string nome;
        private string curso;

        public RegistroAluno()
        {
            this.matricula = 0;
            this.nome = "";
            this.curso = "";
        }

        public RegistroAluno(int matricula, string nome, string curso)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.curso = curso;
        }

        public int getMatricula()
        {
            return this.matricula;
        }

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCurso()
        {
            return this.curso;
        }

        public void setCurso(string curso)
        {
            this.curso = curso;
        }
    }
}
