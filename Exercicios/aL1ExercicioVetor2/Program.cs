using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioVetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Dado um Vetor informe 4 posições de saída utilizando uma Estrutura de Repetição 
             * 2. Nesse exercício devemos informar 2 variáveis apenas */

            string[] modelo = new string[4];

            for(int i=0; i<modelo.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º modelo: ");
                modelo[i] = Console.ReadLine();
            }

            for (int i = 0; i < modelo.Length; i++)
            {
                Console.WriteLine($"Na {i + 1}ª posição ficou o Modelo: {modelo[i]}"); 
            }
            Console.ReadKey();
        }
    }
}
