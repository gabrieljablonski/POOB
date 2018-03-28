using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2DVector
{
    class Vector2D
    {
        private double x_coordinate;
        private double y_coordinate;

        public Vector2D()
        {
            x_coordinate = 0;
            y_coordinate = 0;
        }

        public Vector2D(double x, double y)
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

        public void set_xy(double x, double y)
        {
            set_x(x);
            set_y(y);
        }
        
        public double get_x()
        {
            return x_coordinate;
        }

        public double get_y()
        {
            return y_coordinate;
        }

        public double module()
        {
            return (Math.Pow((Math.Pow(x_coordinate, 2) +
                              Math.Pow(y_coordinate, 2)), 0.5));
        }
        
        public double scalar_product(Vector2D other_vector)
        {
            return (x_coordinate * other_vector.x_coordinate +
                    y_coordinate * other_vector.y_coordinate);
        }

        public double angle_between(Vector2D other_vector, bool degrees=false)
        {
            double theta;
            // Cos(Theta) = (u.v) / (||u||*||v||)
            theta = Math.Acos(scalar_product(other_vector) / (module() * other_vector.module()));
            return ((degrees) ? theta * 180 / Math.PI : theta);
        }

        public Vector2D projection(Vector2D other_vector)
        {
            double other_module, other_x, other_y, cosine, mod;
            other_module = other_vector.module();
            other_x = other_vector.get_x();
            other_y = other_vector.get_y();
            cosine = Math.Cos(angle_between(other_vector));
            mod = module();

            Vector2D unit_vector = new Vector2D(other_x / other_module, other_y / other_module);

            // proj = (|a|*cos(theta))*unit_b
            return (new Vector2D(mod * cosine * unit_vector.get_x(), mod * cosine * unit_vector.get_y()));

        }
    }
}
