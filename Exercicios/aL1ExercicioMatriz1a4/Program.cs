using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioMatriz1a4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Informar 6 valores na Matriz 3 x 2 2. Mostrar a saída dos valores */

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
            for(int i = 0; i < colunas; i++)
            {
                concatCol += $"{divisoria}{divisoria}";
                Console.Write($"{espacoCol}COL{i+1}");
            }
            Console.Write($"\n{concatCol}");
            for (int i = 0; i < linhas; i++)
            {
                Console.Write(quebraLinha);
                for (int j = 0; j < colunas; j++)
                {
                    string espacoReduzido;
                    if (Convert.ToString(exMatriz[i, j]).Length == 1)
                    {
                        espacoReduzido = "    ";
                    }
                    else if(Convert.ToString(exMatriz[i, j]).Length == 2)
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
                }
                Console.Write($"{quebraLinha}{concatCol}");
            }
            Console.ReadKey();
        }
    }
}
