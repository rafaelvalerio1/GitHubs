using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalwExercicio15
{
    class Matriz
    {
        int[,] matrizA = new int[3, 3];
        int[,] matrizB = new int[3, 3];

        public int[,] MatrizA
        {
            get { return matrizA; }
            set { matrizA = value; }
        }
        public int[,] MatrizB
        {
            get { return matrizB; }
            set { matrizB = value; }
        }

        //Métodos
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
        public void LendoDados(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Digite um valor para a posição [{i + 1},{j + 1}]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void ExibindoDados(int[,] matriz)
        {
            string quebraLinha = "\n";
            string espacoNum = "    ";
            string espacoCol = "     ";
            string divisoria = "-----";
            string concatCol = "";
            //Definindo cabeçalho da tabela
            Console.Write(quebraLinha);
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                concatCol += $"{divisoria}{divisoria}";
                Console.Write($"{espacoCol}COL{i + 1}");
            }
            Console.Write($"\n{concatCol}");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(quebraLinha);
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{espacoNum}{matriz[i, j]}{DefinidoEspaco(matriz, i, j)}");
                }
                Console.Write($"{quebraLinha}{concatCol}");
            }
        }
        public int[,] MultiplicacaoMatriz(int[,] matriz1, int[,] matriz2)
        {
            int[,] matriz3 = new int[matriz1.GetLength(0), matriz2.GetLength(1)];
            int temp;
            for (int k1 = 0; k1 < matriz1.GetLength(0); k1++)
            {
                for (int k2 = 0; k2 < matriz2.GetLength(1); k2++)
                {
                    temp = 0;
                    for (int i = 0; i < matriz1.GetLength(1); i++)
                    {
                        temp = temp + matriz1[k1, i] * matriz2[i, k2];
                    }
                    matriz3[k1, k2] = temp;
                }
            }
            return matriz3;
        }
    }
}
