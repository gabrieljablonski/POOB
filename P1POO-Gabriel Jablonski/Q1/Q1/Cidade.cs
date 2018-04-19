using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    class Cidade
    {
        private String nome;
        private Object[,] cidades_proximas;
        private int n_cidades = 0;

        public Cidade()
        {

        }

        public Cidade(String nome)
        {
            this.nome = nome;
            this.cidades_proximas = new Object[10, 2];
        }

        public String getNome()
        {
            return this.nome;
        }

        public void adicionaCidade(Cidade c, int distancia)
        {
            this.cidades_proximas[n_cidades, 0] = c;
            this.cidades_proximas[n_cidades++, 1] = distancia;
        }

        public String maisProxima()
        {
            int mais_proxima = 0;

            for(int i = 0; i<n_cidades; i++)
            {
                if((int)this.cidades_proximas[i, 1] < (int)this.cidades_proximas[mais_proxima, 1])
                {
                    mais_proxima = i;
                }
            }
            Cidade c = (Cidade)this.cidades_proximas[mais_proxima, 0];
            return c.getNome();
        }
    }
}
