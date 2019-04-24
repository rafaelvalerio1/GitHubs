using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio9
{
    class Vetor
    {
        int[] v = new int[10];

        public int[] V
        {
            get { return v; }
            set { v = value; }
        }
        public int RetornarMaiorElemento(int[] vetor)
        {
            int posicao = 0;
            int valor = vetor[0];

            for(int i=0; i<vetor.Length; i++)
            {
                if (vetor[i] > valor)
                {
                    valor = vetor[i];
                    posicao = i;
                }
            }
            return posicao;
        }
        public int RetornarMenorElemento(int[] vetor)
        {
            int posicao = 0;
            int valor = vetor[0];

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < valor)
                {
                    valor = vetor[i];
                    posicao = i;
                }
            }
            return posicao;
        }
    }
}
