using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimuladoProva1
{
    class Resistor
    {
        private double resistencia;
        private double potencia;

        public Resistor()
        {
            this.resistencia = 0;
            this.potencia = 0;
        }

        public Resistor(String _)
        {
            Console.Out.Write("Insira o valor de resistência:\n>>");
            double resistencia = double.Parse(Console.In.ReadLine().Replace(".", ","));
            Console.Out.Write("Insira o valor de potência máxima:\n>>");
            double potencia = double.Parse(Console.In.ReadLine().Replace(".", ","));
            this.resistencia = resistencia;
            this.potencia = potencia;
        }

        public Resistor(double resistencia, double potencia)
        {
            this.resistencia = resistencia;
            this.potencia = potencia;
        }

        public void setResistencia(double resistencia)
        {
            this.resistencia = resistencia;
        }

        public void setPotencia(double potencia)
        {
            this.potencia = potencia;
        }

        public double getResistencia()
        {
            return this.resistencia;
        }

        public double getPotencia()
        {
            return this.potencia;
        }

        public Resistor serie(Resistor outro_resistor)
        {
            double res_equi = this.getResistencia() + outro_resistor.getResistencia();
            double pot_equi = (this.getPotencia() < outro_resistor.getPotencia()) ?
                               this.getPotencia() : outro_resistor.getPotencia();
            return new Resistor(res_equi, pot_equi);
        }

        public Resistor paralelo(Resistor outro_resistor)
        {
            double res_equi = this.getResistencia() * outro_resistor.getResistencia() /
                              (this.getResistencia() + outro_resistor.getResistencia());
            double pot_equi = (this.getPotencia() < outro_resistor.getPotencia()) ?
                               this.getPotencia() : outro_resistor.getPotencia();
            return new Resistor(res_equi, pot_equi);
        }

        public void imprime()
        {
            Console.Out.WriteLine("\tResistência = " + this.getResistencia() + " Ω\n\tPotência = " +
                                  this.getPotencia() + " W");
        }
    }
}
