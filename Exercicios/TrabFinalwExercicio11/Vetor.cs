using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalwExercicio11
{
    class Vetor
    {
        int[] v = new int[6];

        public int[] V
        {
            get { return v; }
            set { v = value; }
        }
        public int[] InverterVetor(int[] vetor)
        {
            int[] resultado = new int[vetor.Length];
            for(int i=0; i<vetor.Length; i++)
            {
                resultado[(vetor.Length - 1) - i] = vetor[i];
            }
            return resultado;
        }
    }
}
