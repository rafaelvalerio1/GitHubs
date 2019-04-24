using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1aExercicioEstCond8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Criar um algoritmo que informe:
                 Em dois valores inteiros, informar:
                 Se o Primeiro > Segundo
                 Se o Segundo > Primeiro
                 Se o Primeiro = Segundo
            */
            int num1, num2;

            Console.Write("Digite o 1º número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("O 1º número é igual ao 2º");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("O 1º número é maior que o 2º");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("O 2º número é maior que o 1º");
            }
            else
            {
                Console.WriteLine("Dados Inválidos");
            }

            Console.ReadKey();
        }
    }
}
