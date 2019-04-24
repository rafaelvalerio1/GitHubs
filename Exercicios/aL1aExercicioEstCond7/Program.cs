using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1aExercicioEstCond7
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
            */
            int num1, num2;

            Console.Write("Digite o 1° número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 2° número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine("O 1° número é maior que o 2°");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("O 2° número é maior que o 1°");
            }
            else
            {
                Console.WriteLine("Os números são iguais");
            }

            Console.ReadKey();

        }
    }
}
