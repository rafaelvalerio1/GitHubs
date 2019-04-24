using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eExercicioVetMat2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaLivros = new List<string>();
            List<string> listaNomes = new List<string>();
            List<int> listaSomaLivros = new List<int>();
            bool repeticao = true;
            bool repeticaoOpcao2 = true;
            int soma = 0;
            int inicial = 0;
            int somatorio = 1;

            while (repeticao)
            {
                if (repeticaoOpcao2 == true)
                {
                    Console.Write("Digite seu nome: ");
                    string nome = Console.ReadLine();
                    listaNomes.Add(nome);
                }

                Console.Write("Digite a quantidade de livros que você quer: ");
                int qtdLivros = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < qtdLivros; i++)
                {
                    Console.Write($"Digite o nome do {inicial + somatorio}º livro: ");
                    string livro = Console.ReadLine();
                    listaLivros.Add(livro);
                    somatorio++;
                }
                soma += qtdLivros;

                Console.WriteLine("\nVocê deseja continuar adicionando livros? Digite [s/n]: ");
                string opcao1 = Console.ReadLine();

                if (opcao1 != "s" && opcao1 != "S")
                {
                    listaSomaLivros.Add(soma);
                    soma = 0;
                    repeticao = false;
                    repeticaoOpcao2 = false;
                    Console.WriteLine("\nMais alguém deseja adicionar livros? Digite [s/n]: ");
                    string opcao2 = Console.ReadLine();

                    if (opcao2 != "s" && opcao2 != "S")
                    {
                        repeticao = false;
                        repeticaoOpcao2 = false;
                    }
                    else
                    {
                        somatorio = 1;
                        repeticao = true;
                        repeticaoOpcao2 = true;
                    }
                }
                else
                {
                    repeticaoOpcao2 = false;
                }
            }
            Console.WriteLine("\n=====* LISTA DE NOMES E LIVROS *=====");
                int valorVariavel = 0;
                int acrescimo;
            for (int i = 0; i < listaNomes.Count; i++)
                {
                    acrescimo = 1;
                    listaSomaLivros[i] += valorVariavel;
                    Console.WriteLine($"\nNome {i + 1}: {listaNomes[i]}");
                    for (int j = valorVariavel; j < listaSomaLivros[i]; j++)
                    {
                        Console.WriteLine($"Livro {acrescimo}: {listaLivros[j]}");
                        acrescimo++;
                    }
                    valorVariavel += listaSomaLivros[i];   
                }
 
            Console.ReadKey();
        }
    }
}
