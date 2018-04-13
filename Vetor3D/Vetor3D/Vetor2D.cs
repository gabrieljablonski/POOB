using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vetor3D
{
    class Vetor2D
    {
        protected double x_coordinate;
        protected double y_coordinate;

        public Vetor2D()
        {
            x_coordinate = 0;
            y_coordinate = 0;
        }

        public Vetor2D(double x, double y)
        {
            x_coordinate = x;
            y_coordinate = y;
        }

        public void set_x(double x)
        {
            x_coordinate = x;
        }

        public void set_y(double y)
        {
            y_coordinate = y;
        }
        
        public double get_x()
        {
            return x_coordinate;
        }

        public double get_y()
        {
            return y_coordinate;
        }

        public virtual double modulo()
        {
            return (Math.Pow((Math.Pow(x_coordinate, 2) +
                              Math.Pow(y_coordinate, 2)), 0.5));
        }
    }
}
