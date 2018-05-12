using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContabilidadeRecursosHumanos
{
    public abstract class Empregado
    {
        protected String nome;
        protected String cpf;
        protected String endereco;

        public Empregado()
        {
            this.nome = "";
            this.cpf = "";
            this.endereco = "";
        }

        public String getNome()
        {
            return this.nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getCPF()
        {
            return this.cpf;
        }

        public void setCPF(String cpf)
        {
            this.cpf = cpf;
        }

        public String getEndereco()
        {
            return this.endereco;
        }

        public void setEndereco(String endereco)
        {
            this.endereco = endereco;
        }

        public void inserirDados()
        {

        }

        public abstract double salario();
        
    }
}
