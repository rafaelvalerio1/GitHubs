using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1aExercicioEstCond9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar um algoritmo de acordo com a saída da tela: */

            int num1, num2;

            Console.Write("Digite o 1º número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"Número {num1} é igual a {num2}");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"Número {num1} é maior que {num2}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"Número {num2} é maior que {num1}");
            }
            else
            {
                Console.WriteLine("Dados Inválidos");
            }
            Console.ReadKey();
        }
    }
}
