using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBibliotecaEstRep2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLivros;

            Console.Write("Digite a quantidade de livros: ");
            numLivros = Convert.ToInt32(Console.ReadLine());

            string livro;
            string livros = "===== Livros =====";

            for (int i = 0; i < numLivros; i++)
            {
                Console.WriteLine("Digite o {0}° livro: ", i + 1);
                livro = Console.ReadLine();

                livros += $"\n{livro}\t";
            }
            Console.WriteLine(livros);

            Console.ReadKey();
        }
    }
}
