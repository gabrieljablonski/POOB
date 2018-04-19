using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimuladoProva1
{
    class Program
    {
        static void Main(string[] args)
        {
            Resistor resistor1 = new Resistor(1.0, 3.0);
            Resistor resistor2 = new Resistor("T");

            Console.Out.WriteLine("Resistor 1:");
            resistor1.imprime();
            Console.Out.WriteLine("Resistor 2:");
            resistor2.imprime();

            Resistor resistor3 = resistor1.serie(resistor2);
            Resistor resistor4 = resistor1.paralelo(resistor2);

            Console.Out.WriteLine("Resistor 3 (Série):");
            resistor3.imprime();
            Console.Out.WriteLine("Resistor 4 (Paralelo):");
            resistor4.imprime();


            Console.In.Read();
        }
    }
}
