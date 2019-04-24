using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioEstRep3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie um Algoritmo que faça a contagem de 1 a 10 na forma decrescente com números impares
                • Estruturapara*/

            int contagem;

            Console.Write("-------* CONTAGEM DECRESCENTE DE NÚMEROS PARES *-------");
            Console.Write("Digite um número para começar a contagem decrescente: ");
            contagem = Convert.ToInt32(Console.ReadLine());

            for(int i = contagem; i >=0; i--)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey(); 
        }
    }
}
