using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor vetor1 = new Vetor();

            for(int i=0; i<vetor1.V.Length; i++)
            {
                Console.Write($"Informe o {i+1}º elemento: ");
                vetor1.V[i] = Convert.ToInt32(Console.ReadLine());
            }

            int menorElemento = vetor1.RetornarMenorElemento(vetor1.V);
            int maiorElemento = vetor1.RetornarMaiorElemento(vetor1.V);
            Console.WriteLine($"\nO menor elemento é o {menorElemento + 1}º valor que é igual a: {vetor1.V[menorElemento]}");

            Console.WriteLine($"O maior elemento é o {maiorElemento + 1}º valor que é igual a: {vetor1.V[maiorElemento]}");

            Console.ReadKey();
        }
    }
}
