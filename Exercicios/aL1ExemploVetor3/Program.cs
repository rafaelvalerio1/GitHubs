using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExemploVetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[2];
            string[] nomeCompleto = new string[2];
            nomeCompleto[0] = "nome";
            nomeCompleto[1] = "sobrenome";

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite seu {nomeCompleto[i]}: ");
                vetor[i] = Console.ReadLine();
            }
            
            Console.WriteLine($"Nome e sobrenome digitados: {vetor[0]} {vetor[1]}");

            Console.ReadKey();
        }
    }
}
