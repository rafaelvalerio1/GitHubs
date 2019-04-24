using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalwExercicio13
{
    class Matriz
    {
        int[,] exMatriz = new int[4, 4];
        int valor;

        public int[,] ExMatriz
        {
            get { return exMatriz; }
            set { exMatriz = value; }
        }
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        //Métodos
        public int RetornarMenorValor(int[,] matriz)
        {
            int valor = exMatriz[0, 0];
            for (int i = 0; i < exMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < exMatriz.GetLength(1); j++)
                {
                    if (exMatriz[i, j] < valor)
                    {
                        valor = exMatriz[i, j];
                    }
                }
            }
            return valor;
        }
        public int RetornarMaiorValor(int[,] matriz)
        {
            int valor = exMatriz[0, 0];
            for (int i = 0; i < exMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < exMatriz.GetLength(1); j++)
                {
                    if (exMatriz[i, j] > valor)
                    {
                        valor = exMatriz[i, j];
                    }
                }
            }
            return valor;
        }
        public string DefinidoEspaco(int[,] matriz, int indiceLinhas, int indiceColunas)
        {
            string espacoReduzido;
            string tamanhoCaractere = Convert.ToString(matriz[indiceLinhas, indiceColunas]);
            if (tamanhoCaractere.Length == 1)
            {
                espacoReduzido = "    ";
            }
            else if (tamanhoCaractere.Length == 2)
            {
                espacoReduzido = "   ";
            }
            else if (tamanhoCaractere.Length == 3)
            {
                espacoReduzido = "  ";
            }
            else
            {
                espacoReduzido = " ";
            }
            return espacoReduzido;
        }

        public List<int> PesquisarElemento(int[,] matriz, int numDigitado)
        {
            int posicaoLinha = 0;
            int posicaoColuna = 0;
            List<int> listaElementos = new List<int>();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == numDigitado)
                    {
                        posicaoLinha = i;
                        posicaoColuna = j;
                        listaElementos.Add(posicaoLinha);
                        listaElementos.Add(posicaoColuna);
                    }
                } 
            }
            return listaElementos;
        }
    }
}
