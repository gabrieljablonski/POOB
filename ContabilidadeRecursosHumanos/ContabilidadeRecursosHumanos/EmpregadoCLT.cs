using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContabilidadeRecursosHumanos
{
    public class EmpregadoCLT : Empregado
    {
        private double sBrutoCLT;

        public EmpregadoCLT():base()
        {
            this.sBrutoCLT = 0.0;
        }

        public double getSBrutoCLT()
        {
            return this.sBrutoCLT;
        }

        public void setSBrutoCLT(double sBrutoCLT)
        {
            this.sBrutoCLT = sBrutoCLT;
        }

        public void inserirDadosCLT(String nome, String cpf, String endereco, double sBrutoCLT)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.sBrutoCLT = sBrutoCLT;
        }

        public override double salario()
        {
            return this.sBrutoCLT < 5000 ? .85 * this.sBrutoCLT : .725 * this.sBrutoCLT;
        }
    }
}
