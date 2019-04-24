using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioEstRep7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crie um Algoritmo com LAÇOS CONDICIONAIS fazendo uma tabuada*/

            int tabuadaNum, tabuadaMult, tabuada;

            do
            {
                Console.Clear();
                Console.Write("Quer calcular a tabuada de qual número? R: ");
                tabuadaNum = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Deseja multiplicar o número {tabuadaNum} até qual valor? R: ");
                tabuadaMult = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\n--------TABUADA DO {tabuadaNum}--------");
                for (int i = 0; i <= tabuadaMult; i++)
                {
                    tabuada = tabuadaNum * i;
                    Console.WriteLine($"{tabuadaNum} x {i} = {tabuada}");
                }
                Console.WriteLine("Deseja continuar? Digite sim ou [enter] para não");
            } while (!string.IsNullOrEmpty(Console.ReadLine()));
        }
    }
}
