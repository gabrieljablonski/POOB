using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vetor3D
{
    class Vetor3D : Vetor2D
    {
        private double z_coordinate;

        public Vetor3D():base()
        {
            this.z_coordinate = 0;
        }

        public Vetor3D(double x, double y, double z):base(x, y)
        {
            this.z_coordinate = z;
        }

        public void set_z(double z)
        {
            this.z_coordinate = z;
        }

        public double get_z()
        {
            return this.z_coordinate;
        }

        public override double modulo()
        {
            return (Math.Pow((Math.Pow(x_coordinate, 2) +
                              Math.Pow(y_coordinate, 2) + 
                              Math.Pow(z_coordinate, 2)), 0.5));
        }
        // u x v = (uy*vz - uz*vy)i + (ux*vz - uz*vx)j + (ux*vy - uy*vx)k
        public Vetor3D produto_vetorial(Vetor3D outro_vetor)
        {
            return new Vetor3D(this.get_y()*outro_vetor.get_z() - this.get_z()*outro_vetor.get_y(),
                               this.get_x()*outro_vetor.get_z() - this.get_z()*outro_vetor.get_x(),
                               this.get_x()*outro_vetor.get_y() - this.get_y()*outro_vetor.get_x());
        }
    }
}
