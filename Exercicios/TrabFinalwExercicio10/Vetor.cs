using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalwExercicio10
{
    class Vetor
    {
        int[] v = new int[10];
        int valor;

        public int[] V
        {
            get { return v; }
            set { v = value; }
        }
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public int RetornarMaiorElemento(int[] vetor)
        {
            int posicao = 0;
            int valor = vetor[0];
            for (int i = 0; i < vetor.Length; i++)
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
        public List<int> PesquisarElementoIgual(int[] vetor, int numDigitado)
        {
            int posicao = 0;
            List<int> listaElementos = new List<int>();

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == numDigitado)
                {
                    posicao = i;
                    listaElementos.Add(posicao);
                }
            }
            return listaElementos;
        }
    }
}
