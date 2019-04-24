using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aVeiculoPOO
{
    class Veiculo
    {
        public string cor;
        public string modelo;
        public string marca;
        public string motor;
        public string chassi;
        public int roda;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }
        public string Chassi
        {
            get { return chassi; }
            set { chassi = value; }
        }
        public int Roda
        {
            get { return roda; }
            set { roda = value; }
        }

    }
}
