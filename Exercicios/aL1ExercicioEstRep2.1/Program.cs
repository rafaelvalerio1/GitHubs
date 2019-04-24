using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioEstRep2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contagem;
            int i = 0;

            Console.Write("Quer contar até qual número? R: ");
            contagem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-------NÚMEROS IMPARES-------");
            do
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= contagem);
            Console.ReadKey();
        }
    }
}
