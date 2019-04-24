using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eExercicioVetMat2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeticao = true;
            List<string> listaLivros = new List<string>();

            while (repeticao)
            {
                Console.WriteLine("Quantos livros você quer? R:");
                int qtdLivros = Convert.ToInt32(Console.ReadLine());

                for (int i=0; i<qtdLivros; i++)
                {
                    Console.Write($"Digite o nome do {i+1}º livro: ");
                    string livro = Console.ReadLine();
                    listaLivros.Add(livro);
                }
  
                Console.Write("Deseja continuar adicionando livros? Digite [s/n]: ");
                string opcao = Console.ReadLine();

                if (opcao != "s" && opcao != "S")
                    repeticao = false;
            }
            Console.WriteLine("\n========* LIVROS *========");
            foreach(string livros in listaLivros)
            {
                Console.WriteLine($"{livros} \t");
            }
            Console.ReadKey();
        }
    }
}
