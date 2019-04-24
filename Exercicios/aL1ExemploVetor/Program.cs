using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExemploVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[2];
            
            for(int i = 0; i < x.Length; i++)
            {
                Console.Write("Digite um valor: ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < x.Length; i++)
            {
                if(i==0)
                {
                    Console.Write($"Os valores digitados foram {x[i]} e ");
                }
                else
                {
                    Console.Write($"{x[i]}");
                }  
            }

            Console.ReadKey();
        }
    }
}
