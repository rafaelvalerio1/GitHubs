using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1aExercicioEstCond4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar um algoritmo que informe: 
             *  Se o número é maior que 10*/

            int num = 0;

            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num>10)
            {
                Console.WriteLine("\nO número é maior que 10");
            }
            else
            {
                Console.WriteLine("\nO número não é maior que 10");
            }

            Console.ReadKey();
        }
    }
}
