using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExemploVetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];

            for(int i=1; i<=x.Length; i++)
            {
                Console.Write($"Digite o {i}º valor: ");
                x[i-1] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"O 1º valor digitado foi {x[0]}");

            Console.ReadKey();
        }
    }
}
