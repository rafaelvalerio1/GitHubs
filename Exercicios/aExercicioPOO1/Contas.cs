using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aExercicioPOO1
{
    class Contas
    {
        //Atributos
        int numero1, numero2;

        //Propriedades
        public int Numero1
        {
            get { return numero1; }
            set { numero1 = value; }
        }
        public int Numero2
        {
            get { return numero2; }
            set { numero2 = value; }
        }

        //Métodos
        public int Somar(int num1, int num2)
        {
            int soma = num1 + num2;
            return soma;
        }

    }
}
