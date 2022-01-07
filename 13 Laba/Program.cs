using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(1, 2, 3);
            RectangularTriangle rectangularTriangle = new RectangularTriangle();

        }
    }
    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle()
        {

        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
    class RectangularTriangle : Triangle
    {
        public RectangularTriangle(double a, double b)
        {
            A = a;
            B = b;
            C = Math.Sqrt(a * a + b * b);
        }

    }
}
