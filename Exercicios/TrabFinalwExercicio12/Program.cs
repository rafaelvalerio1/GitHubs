using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalwExercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz matriz1 = new Matriz();

            string quebraLinha = "\n";
            string espacoNum = "    ";
            string espacoCol = "     ";
            string divisoria = "-----";
            string concatCol = "";

            //Lendo os dados
            for (int i = 0; i < matriz1.ExMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.ExMatriz.GetLength(1); j++)
                {
                    Console.Write($"Digite um valor para a posição [{i},{j}]: ");
                    matriz1.ExMatriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Definindo cabeçalho da tabela
            Console.Write(quebraLinha);
            for (int i = 0; i < matriz1.ExMatriz.GetLength(1); i++)
            {
                concatCol += $"{divisoria}{divisoria}";
                Console.Write($"{espacoCol}COL{i + 1}");
            }
            //Exibindo os dados e definido a estrutura da tabela
            Console.Write($"\n{concatCol}");
            for (int i = 0; i < matriz1.ExMatriz.GetLength(0); i++)
            {
                Console.Write(quebraLinha);
                for (int j = 0; j < matriz1.ExMatriz.GetLength(1); j++)
                {
                    Console.Write($"{espacoNum}{matriz1.ExMatriz[i, j]}{matriz1.DefinidoEspaco(matriz1.ExMatriz, i, j)}");
                }
                Console.Write($"{quebraLinha}{concatCol}");
            }
            Console.WriteLine($"\n\nO menor é: {matriz1.RetornarMenorValor(matriz1.ExMatriz)}");
            Console.WriteLine($"O maior é: {matriz1.RetornarMaiorValor(matriz1.ExMatriz)}");
            Console.ReadKey();
        }
    }
}
