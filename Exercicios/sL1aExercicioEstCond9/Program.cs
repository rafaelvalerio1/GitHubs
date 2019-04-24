using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9) Crie um Programa em C# que leia dois valores (considere que não serão lidos valores iguais) e escrevê-los em ordem crescente. */

            int[] valor = new int[4];
            int aux;

            //Lendo os valores
            for(int i=0; i<valor.Length; i++)
            {
                Console.Write("Digite o {0}° valor: ", i+1);
                valor[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Lógica para deixar valores em ordem crescente no vetor
            for(int i=0; i<valor.Length; i++)
            {
                for(int j = i+1; j<valor.Length; j++)
                {
                    if(valor[i] > valor[j])
                    {
                        aux = valor[i];
                        valor[i] = valor[j];
                        valor[j] = aux;
                    }
                }
            }
            //Exibindo os valores
            for (int i=0; i<valor.Length; i++)
            {
                string separador = " - ";
                if(i < valor.Length - 1)
                {
                    Console.Write("{0}{1}", valor[i], separador);
                }
                else if(i<valor.Length)
                {
                    Console.Write(valor[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
