using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cidade araguari = new Cidade("Araguari");
            Cidade uberlandia = new Cidade("Uberlandia");
            Cidade cascalho_rio = new Cidade("Cascalho Rio");
            Cidade estrela_do_sul = new Cidade("Estrela do Sul");
            araguari.adicionaCidade(uberlandia, 30);
            araguari.adicionaCidade(cascalho_rio, 28);
            araguari.adicionaCidade(estrela_do_sul, 34);

            Console.Out.WriteLine("Cidade mais proxima de Araguari: " + araguari.maisProxima());
            Console.In.Read();
        }
    }
}
