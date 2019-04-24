using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalwExercicio12
{
    class Matriz
    {
        int[,] exMatriz = new int[4, 4];

        public int[,] ExMatriz
        {
            get { return exMatriz; }
            set { exMatriz = value; }
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
    }
}
