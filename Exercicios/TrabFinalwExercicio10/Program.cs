using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalwExercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor vetor1 = new Vetor();

            for (int i = 0; i < vetor1.V.Length; i++)
            {
                Console.Write($"Informe o {i + 1}º elemento: ");
                vetor1.V[i] = Convert.ToInt32(Console.ReadLine());
            }
            int menorElemento = vetor1.RetornarMenorElemento(vetor1.V);
            int maiorElemento = vetor1.RetornarMaiorElemento(vetor1.V);
            
            Console.WriteLine($"\nO menor elemento é o {menorElemento + 1}º valor que é igual a: {vetor1.V[menorElemento]}");

            Console.WriteLine($"O maior elemento é o {maiorElemento + 1}º valor que é igual a: {vetor1.V[maiorElemento]}");

            bool repeticao = true;
            while(repeticao)
            {
                Console.Write("\nDigite um valor para procurar: ");
                vetor1.Valor = Convert.ToInt32(Console.ReadLine());

                List<int> igualElemento = vetor1.PesquisarElementoIgual(vetor1.V, vetor1.Valor);
                if (igualElemento.Count == 0)
                {
                    Console.WriteLine("O número não foi encontrado");
                }
                else
                {
                    for (int i = 0; i < igualElemento.Count; i++)
                    {
                        Console.WriteLine($"O valor {vetor1.Valor} está na {igualElemento[i] + 1}ª posição");
                    }
                }
                Console.WriteLine("\nDeseja continuar procurando valores? Digite [s/n]");
                char opcao = Char.Parse(Console.ReadLine());
                if(opcao!='S' && opcao!='s')
                {
                    repeticao = false;
                }
            }

            Console.ReadKey();
        }
    }
}
