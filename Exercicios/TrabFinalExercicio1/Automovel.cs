using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio1
{
    class Automovel
    {
        double distancia, consumo;

        public double Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }
        public double Consumo
        {
            get { return consumo; }
            set { consumo = value; }
        }

        public double ConsumoMedio(double dist, double con)
        {
            double resultado = dist / con;
            return resultado;
        }

    }
}
