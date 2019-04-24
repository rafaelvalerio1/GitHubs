using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalwExercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor vetor1 = new Vetor();

            for(int i=0; i<vetor1.V.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º elemento: ");
                vetor1.V[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n========* INVERSÃO DE VALORES *========");
            for(int i=0; i<vetor1.V.Length; i++)
            {
                Console.WriteLine($"Valor {i + 1}: {vetor1.InverterVetor(vetor1.V)[i]}");
            }
            Console.ReadKey();

        }
    }
}
