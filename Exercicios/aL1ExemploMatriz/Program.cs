using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExemploMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = 3;
            int colunas = 2;
            string quebraLinha = "\n";
            string espaco = "     ";
            string divisoria = "-------------";

            int[,] exMatriz = new int[linhas, colunas];
            exMatriz[0, 0] = 10;
            exMatriz[2, 1] = 4;

            Console.Write($"\n{espaco}COL1{espaco}COL2");
            Console.Write($"\n{espaco}{divisoria}");
            for (int i = 0; i < linhas; i++)
            {
                Console.Write(quebraLinha);
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{espaco}{exMatriz[i, j]}{espaco}");
                }
                Console.Write($"{quebraLinha}{espaco}{divisoria}");
            }
            Console.ReadKey();
        }
    }
}
