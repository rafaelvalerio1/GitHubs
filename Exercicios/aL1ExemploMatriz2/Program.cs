using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExemploEstRep
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = 3;
            int colunas = 3;
            string quebraLinha = "\n";
            string espaco = "     ";
            string divisoria = "------------------------";

            int[,] exMatriz = new int[linhas, colunas];
       
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Digite um valor para a posição [{i},{j}]: ");
                    exMatriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write($"\n{espaco}COL1{espaco}COL2{espaco}COL3");
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
