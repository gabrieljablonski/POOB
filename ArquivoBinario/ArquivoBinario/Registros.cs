using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquivoBinario
{
    [Serializable]

    public class Registros
    {
        private int conta;
        private string primeiro_nome;
        private string ultimo_nome;
        private double saldo;

        public Registros(int conta, string primeiro_nome, string ultimo_nome, double saldo)
        {
            this.conta = conta;
            this.primeiro_nome = primeiro_nome;
            this.ultimo_nome = ultimo_nome;
            this.saldo = saldo;
        }

        public int getConta()
        {
            return this.conta;
        }

        public string getPrimeiroNome()
        {
            return this.primeiro_nome;
        }

        public string getUltimoNome()
        {
            return this.ultimo_nome;
        }

        public double getSaldo()
        {
            return this.saldo;
        }
    }
}
