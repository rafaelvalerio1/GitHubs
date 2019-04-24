using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioEstRep2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crie um Algoritmo que faça a contagem de 1 a 10 mostrando apenas números impares
                • Estrutura enquanto 
                • Estrutura faca enquanto*/

            int contagem;
            int i = 0;

            Console.Write("Quer contar até qual número? R: ");
            contagem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-------NÚMEROS IMPARES-------");
            while (i <= contagem)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
