using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioEstRep5e6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie um Algoritmo com LAÇOS CONDICIONAIS que leia número inicial e número final e mostre a contagem desse intervalo
            • Estrutura enquanto*/

            int numInicial, numFinal;

            do
            {
                Console.Clear();
                Console.WriteLine("\n=======* CONTAGEM NUMÉRICA *=======");
                Console.Write("Digite um numero para contagem inicial: ");
                numInicial = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite um numero para contagem final: ");
                numFinal = Convert.ToInt32(Console.ReadLine());

                if (numInicial < numFinal)
                {
                    while (numInicial <= numFinal)
                    {
                        Console.WriteLine(numInicial);
                        numInicial++;
                    }
                }
                else if (numInicial > numFinal)
                {
                    while (numInicial >= numFinal)
                    {
                        Console.WriteLine(numInicial);
                        numInicial--;
                    }
                }
                else
                {
                    Console.WriteLine(numInicial);
                }

                Console.WriteLine("Deseja continuar? Digite sim ou [enter] para não");
            } while (!string.IsNullOrEmpty(Console.ReadLine()));
        }
    }
}
