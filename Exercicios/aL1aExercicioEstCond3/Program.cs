using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1aExercicioEstCond3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Criar um algoritmo que informe:
                 Se o número digitado é par ou impar
                 Para esta situação devemos criar uma expressão
                que me traga o resto da divisão inteira:
                 numero%2=0
            */
            int num;

            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine("\nO número digitado é PAR");
            }
            else
            {
                Console.WriteLine("\nO número digitado é IMPAR");
            }

            Console.ReadKey();
        }
    }
}
