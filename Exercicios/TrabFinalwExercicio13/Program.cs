using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalwExercicio13
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

            bool repeticao = true;
            while (repeticao)
            {
                Console.Write("\nDigite um valor para procurar: ");
                matriz1.Valor = Convert.ToInt32(Console.ReadLine());

                List<int> igualElemento = matriz1.PesquisarElemento(matriz1.ExMatriz, matriz1.Valor);
                if (igualElemento.Count == 0)
                {
                    Console.WriteLine("O número não foi encontrado");
                }
                else
                {
                    for (int i = 0; i < igualElemento.Count; i+=2)
                    {
                        Console.WriteLine($"O valor {matriz1.Valor} está na linha {igualElemento[i]+1}, coluna {igualElemento[i+1]+1}");
                    }
                }
                Console.WriteLine("\nDeseja continuar procurando valores? Digite [s/n]");
                char opcao = Char.Parse(Console.ReadLine());
                if (opcao != 'S' && opcao != 's')
                {
                    repeticao = false;
                }
            }

            Console.ReadKey();
        }
    }
}
