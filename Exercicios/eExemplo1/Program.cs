using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            LivrosComList();
            LivrosComArray();
            Console.ReadKey();
        }
        static void LivrosComList()
        {
            List<string> livros = new List<string>();

            Console.WriteLine("Quantos livros?");
            var numeroLivros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numeroLivros; i++)
            {
                Console.WriteLine("Qual o livro?");
                var livro = Console.ReadLine();
                livros.Add(livro);
            }

            Console.WriteLine("");
            Console.WriteLine("Livros alugados:");
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }

        }
        static void LivrosComArray()
        {
            Console.WriteLine("Quantos livros?");
            var numeroLivros = Convert.ToInt32(Console.ReadLine());


            string[] livros = new string[numeroLivros];
            for (int i = 0; i < numeroLivros; i++)
            {
                Console.WriteLine("Qual o livro?");
                var livro = Console.ReadLine();
                livros[i] = livro;
            }

            Console.WriteLine("");
            Console.WriteLine("Livros alugados:");
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }

        }
    }
}
