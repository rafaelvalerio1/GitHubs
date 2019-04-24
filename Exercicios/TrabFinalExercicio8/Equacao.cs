using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio8
{
    class Equacao
    {
        double a, b, c;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double CalcularDelta(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4*a*c);
            return delta;
        }
        public double CalcularRaiz(double a, double b, double c, char sinal)
        {
            double raiz = 0.0;
            switch (sinal)
            {
                case '+':
                    raiz = (-b + Math.Sqrt(CalcularDelta(a, b, c))) / (2*a);
                    break;
                case '-':
                    raiz = (-b - Math.Sqrt(CalcularDelta(a, b, c))) / (2*a);
                    break;
            }
            return raiz;
        }
    }
}
