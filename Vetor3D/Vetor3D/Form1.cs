using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vetor3D
{
    public partial class formVetor3D : Form
    {
        public formVetor3D()
        {
            InitializeComponent();
            btnCalcula.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vetor3D vetor1 = new Vetor3D(double.Parse(txtX1.Text.Replace(".", ",")), double.Parse(txtY1.Text.Replace(".", ",")), double.Parse(txtZ1.Text.Replace(".", ",")));
            Vetor3D vetor2 = new Vetor3D(double.Parse(txtX2.Text.Replace(".", ",")), double.Parse(txtY2.Text.Replace(".", ",")), double.Parse(txtZ2.Text.Replace(".", ",")));
            Vetor3D produto_vetorial = vetor1.produto_vetorial(vetor2);

            txtOutput.Text = ">Módulo:\nVetor 1 = " + vetor1.modulo().ToString("F") + "\nVetor 2 = " + vetor2.modulo().ToString("F") +
                             "\n\nVetor 1 x Vetor 2:\n" + produto_vetorial.get_x().ToString("#.##;- #.##;0") + "i " + 
                             produto_vetorial.get_y().ToString("+ #.##;- #.##;+ 0") + "j " + produto_vetorial.get_z().ToString("+ #.##;- #.##;+ 0") + "k\n";
        }
    }
}
