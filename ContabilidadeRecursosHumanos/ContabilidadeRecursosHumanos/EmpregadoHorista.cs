using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContabilidadeRecursosHumanos
{
    public class EmpregadoHorista: Empregado
    {
        private int nHoras;
        private double precoH;

        public EmpregadoHorista() : base()
        {
            this.nHoras = 0;
            this.precoH = 0.0;
        }

        public int getNHoras()
        {
            return this.nHoras;
        }
        
        public void setNHoras(int nHoras)
        {
            this.nHoras = nHoras;
        }

        public double getPrecoH()
        {
            return this.precoH;
        }

        public void setPrecoH(double precoH)
        {
            this.precoH = precoH;
        }

        public void inserirDadosHorista(String nome, String cpf, String endereco, int nHoras, double precoH)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.nHoras = nHoras;
            this.precoH = precoH;
        }

        public override double salario()
        {
            return this.nHoras * this.precoH * 0.85;
        }
    }
}
