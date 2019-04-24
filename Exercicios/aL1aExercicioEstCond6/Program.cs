using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1aExercicioEstCond6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Criar um algoritmo que informe:
                 As categorias de acordo com a idade:
                 Infantil até os 11 anos
                 Adolescente de 12 a 17 anos
                 Adultos 18 a 64 anos
                 Idosos acima de 64 anos
            */

            int idade;

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if(idade<=11)
            {
                Console.WriteLine("\nSua categoria é INFANTIL");
            }
            else if(idade>=12 && idade<=17)
            {
                Console.WriteLine("Sua categoria é ADOLESCENTE");
            }
            else if(idade>=18 && idade<=64)
            {
                Console.WriteLine("Sua categoria é ADULTO");
            }
            else if(idade>64)
            {
                Console.WriteLine("Sua categoria é IDOSO");
            }
            else
            {
                Console.WriteLine("Opção Inválida");
            }

            Console.ReadKey();

        }
    }
}
