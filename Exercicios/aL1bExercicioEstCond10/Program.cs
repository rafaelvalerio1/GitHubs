using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1bExercicioEstCond10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Criar um algoritmo que informe um intervalo digitado de 1 a 5
               2. Caso seja digitado um número maior ou menor que o intervalo requerido, informar que é apenas para digitar o intervalo informado*/

            int num;

            Console.Write("Digite um número de 1 a 5: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >=1 && num<=5)
            {
                Console.WriteLine($"O número digitado foi {num}");
            }
            else
            {
                Console.WriteLine("Digite um número de 1 a 5 apenas!");
            }
            Console.ReadKey();
        }
    }
}
