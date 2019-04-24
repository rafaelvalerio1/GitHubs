using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBibliotecaEstRep1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLivros;

            Console.WriteLine("Quantos livros você vai levar? R: ");
            numLivros = Convert.ToInt32(Console.ReadLine());

            string[] livro = new string[numLivros];

            for (int i = 0; i < numLivros; i++)
            {
                Console.WriteLine("Digite o {0}° livro: ", i + 1);
                livro[i] = Console.ReadLine();
            }

            Console.Write("\n===== LIVROS =====");
            for (int i = 0; i < numLivros; i++)
            {
                Console.Write($"\n{livro[i]}\t");
            }
            Console.ReadKey();
        }
    }
}
