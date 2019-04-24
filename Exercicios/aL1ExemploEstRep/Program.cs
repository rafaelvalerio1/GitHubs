using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExemploEstRep
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie um Algoritmo que calcule a área de um quadrado*/

            double aresta, area;
            do
            {
                Console.Write("Informe o valor da aresta: ");
                aresta = Convert.ToDouble(Console.ReadLine());
            } while (aresta<=0);
            area = aresta * aresta;
            Console.WriteLine($"A área é: {area}");
            Console.ReadKey();
        }
    }
}
