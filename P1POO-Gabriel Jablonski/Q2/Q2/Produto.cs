using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2
{
    class Produto
    {
        private String nome;
        private String codigo;
        private double valor;

        public Produto()
        {
            this.nome = "";
            this.codigo = "";
            this.valor = 0.0;
        }

        public Produto(String nome, String codigo, double valor)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.valor = valor;
        }

        public String getNome()
        {
            return this.nome;
        }

        public String getCodigo()
        {
            return this.codigo;
        }

        public double getValor()
        {
            return this.valor;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setCodigo(String codigo)
        {
            this.codigo = codigo;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }
    }
}
