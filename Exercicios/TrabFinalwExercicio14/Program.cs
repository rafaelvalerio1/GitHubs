using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalwExercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Loteria loteria1 = new Loteria();
            loteria1.QtdNumeros = 3;

            List<int> listaNumerosJogados = new List<int>();
            List<string> listaNome = new List<string>();
            List<int> listaJogo = new List<int>();
            bool repeticao = true;
            int cont1 = 1;
            int cont2 = loteria1.QtdNumeros;
            int cont3 = 0;

            //Adicionando o Jogo premiado em uma lista
            for (int i = 0; i < loteria1.QtdNumeros; i++)
            {
                listaJogo.Add(loteria1.GerarJogoAleatorio(loteria1.QtdNumeros)[i]);
            }
            //Adicionando os jogadores e os números apostados
            while (repeticao)
            {
                Console.Write("Digite seu nome: ");
                loteria1.Nome = Console.ReadLine();
                listaNome.Add(loteria1.Nome);
                for (int i = 0; i < loteria1.QtdNumeros; i++)
                {
                    Console.Write($"Digite o {i + 1}º número [de 1 a 10]: ");
                    loteria1.Numero = Convert.ToInt32(Console.ReadLine());
                    listaNumerosJogados.Add(loteria1.Numero);
                }
                Console.Write("\nMais alguém vai tentar a sorte? [s/n]: ");
                char opcao = Char.Parse(Console.ReadLine());
                if (opcao != 'S' && opcao != 's')
                    repeticao = false;
            }
            //Exibindo o resultado
            for (int i = 0; i < listaNome.Count; i++)
            {
                Console.WriteLine($"\n\n=====* JOGADOR {i + 1} *=====");
                Console.WriteLine($"Nome: {listaNome[i]}");
                Console.Write("Numeros Jogados: ");
                for (int j = cont3; j < cont2; j++)
                {
                    if (j == cont2 - 1)
                        Console.Write($"{listaNumerosJogados[j]}");
                    else
                        Console.Write($"{listaNumerosJogados[j]} - ");
                }
                Console.Write("\nNumeros Premiados: ");
                for (int k = 0; k < loteria1.QtdNumeros; k++)
                {
                    if (k == loteria1.QtdNumeros - 1)
                        Console.Write($"{listaJogo[k]}");
                    else
                        Console.Write($"{listaJogo[k]} - ");
                }
                Console.Write("\nResultado: ");
                string resultado1 = loteria1.VerificarRequisito(cont1, cont2, cont3, listaNumerosJogados);
                int resultado2 = loteria1.ContarAcertos(cont3, cont2, listaNumerosJogados, listaJogo);

               if (string.IsNullOrWhiteSpace(resultado1))
                {
                    if (resultado2 < loteria1.QtdNumeros)
                        Console.Write($"VOCÊ PERDEU...acertou {resultado2} número(s)");
                    else if (resultado2 == loteria1.QtdNumeros)
                        Console.Write($"PARABÉNS VOCÊ GANHOU!...acertou os {resultado2} números");
                }   
                else
                    Console.Write(resultado1);

                cont1 += loteria1.QtdNumeros;
                cont2 += loteria1.QtdNumeros;
                cont3 += loteria1.QtdNumeros;
            }
            Console.ReadKey();
        }
    }
}
