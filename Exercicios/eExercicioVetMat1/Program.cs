using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eExercicioVetMat1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPedidos = 3;
            int numMesas = 8;
            string[,] mesas = new string[numMesas, maxPedidos];
    
            for (int i=0; i<maxPedidos; i++)
            {
                Console.Write("Informe sua mesa: ");
                var mesaEntrada = int.Parse(Console.ReadLine());

                Console.Write($"Informe seu {i + 1}º pedido: ");
                var produtoEntrada = Console.ReadLine();

                mesas[mesaEntrada, i] = produtoEntrada;
            }

            for(int i=0; i<numMesas; i++)
            {
                Console.WriteLine("");
                Console.Write("Mesa: ");
                for(int j=0; j<maxPedidos; j++)
                {
                    Console.Write(mesas[i, j] + "|\t");
                }
            }
            Console.ReadKey();
        }
    }
}
