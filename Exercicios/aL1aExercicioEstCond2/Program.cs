using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1aExercicioEstCond2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Criar um algoritmo que informe: 
             *  Aluno aprovado 
             *  Aluno em recuperação 
             *  Aluno reprovado 
             * 
             *  Aprovação = maior e igual que 7 
             *  Recuperação = menor que 7 
             *  Reprovado = menor que 5*/

            double nota;

            Console.Write("Digite a sua nota: ");
            nota = Convert.ToDouble(Console.ReadLine());

            if(nota<=4)
            {
                Console.WriteLine($"Você tirou nota {nota} e por isso está REPROVADO");
            }
            else if(nota>=5 && nota<=6)
            {
                Console.WriteLine($"Você tirou nota {nota} e por isso está  de RECUPERAÇÃO");
            }
            else if (nota >= 7 && nota <= 10)
            {
                Console.WriteLine($"Você tirou nota {nota} e por isso está APROVADO");
            }
            else
            {
                Console.WriteLine("Digite a nota de 1 a 10");
            }

            Console.ReadKey();
        }
    }
}
