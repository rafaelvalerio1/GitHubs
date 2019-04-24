using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBibliotecaEstRep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLivros;
            string livro;
            List<string> listaLivros = new List<string>();

            Console.WriteLine("Quantos livros você vai levar? R: ");
            numLivros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numLivros; i++)
            {
                Console.WriteLine("Digite o {0}° livro: ", i + 1);
                livro = Console.ReadLine();

                //Adiciona o item à lista
                listaLivros.Add(livro);
            }

            Console.Write("\n===== LIVROS =====\n");
            //Ordena a lista 
            listaLivros.Sort();
            listaLivros.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}
