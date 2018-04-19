using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2
{
    class Estabelecimento
    {
        private List<Produto> produtos;
        private String nome;
        private String cnpj;

        public Estabelecimento()
        {
            this.produtos = new List<Produto>();
            this.nome = "";
            this.cnpj = "";
        }

        public Estabelecimento(String nome, String cnpj, List<Produto> produtos)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.produtos = produtos;
        }

        public String getNome()
        {
            return this.nome;
        }

        public String getCNPJ()
        {
            return this.cnpj;
        }

        public void adicionarProduto(Produto produto)
        {
            this.produtos.Add(produto);
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setCNPJ(String cnpj)
        {
            this.cnpj = cnpj;
        }

        public void imprimeComprovante()
        {

        }
    }
}
