using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioMatriz5
{
    class Program
    {
        /*1. Criar um algoritmo que leia uma matrizes 3 x 3 2. Exiba a soma dos elementos de cada uma das linhas 3. A soma deverá ser feita dentro do Loop*/

        static void Main(string[] args)
        {
            int linhas;
            int colunas;
            string quebraLinha = "\n";
            string espacoNum = "    ";
            string espacoCol = "     ";
            string divisoria = "-----";
            string concatCol = "";

            Console.Write("Digite o número de linhas da tabela: ");
            linhas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número de colunas da tabela: ");
            colunas = Convert.ToInt32(Console.ReadLine());

            int[,] exMatriz = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Digite um valor para a posição [{i},{j}]: ");
                    exMatriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write(quebraLinha);
            for (int i = 0; i < colunas; i++)
            {
                concatCol += $"{divisoria}{divisoria}";
                Console.Write($"{espacoCol}COL{i + 1}");
            }
            Console.Write($"\n{concatCol}");
            for (int i = 0; i < linhas; i++)
            {
                string espacoReduzido;
                int somaLinha = 0;
                Console.Write(quebraLinha);
                for (int j = 0; j < colunas; j++)
                {
                    if (Convert.ToString(exMatriz[i, j]).Length == 1)
                    {
                        espacoReduzido = "    ";
                    }
                    else if (Convert.ToString(exMatriz[i, j]).Length == 2)
                    {
                        espacoReduzido = "   ";
                    }
                    else if (Convert.ToString(exMatriz[i, j]).Length == 3)
                    {
                        espacoReduzido = "  ";
                    }
                    else
                    {
                        espacoReduzido = " ";
                    }
                    Console.Write($"{espacoNum}{exMatriz[i, j]}{espacoReduzido}");
                    somaLinha += exMatriz[i, j];
                }
                Console.Write($"{espacoNum}//A soma da Linha {i+1} é: {somaLinha}");
                Console.Write($"{quebraLinha}{concatCol}");
            }
            Console.ReadKey();
        }
    }
}
