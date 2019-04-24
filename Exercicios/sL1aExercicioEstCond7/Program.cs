using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7) Faça um Programa em C# que leia três notas de um aluno, calcule e escreva a média final deste aluno. Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5. Fórmula para o cálculo da média final é: 
             *                     n1 * 2 + n2 * 3 + n3 * 5
               mediafinal =   -----------------------------------      
                                             10                     */

            int peso1 = 2;
            int peso2 = 3;
            int peso3 = 5;
            int somaPesos;
            double n1, n2, n3, mediaFinal;

            Console.Write("\n---------CÁLCULO DA MÉDIA---------\n");
            Console.Write("Digite a 1ª nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a 2ª nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a 3ª nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            somaPesos = peso1 + peso2 + peso3;
            mediaFinal = ((n1 * peso1) + (n2 * peso2) + (n3 * peso3)) / somaPesos;

            Console.WriteLine("A sua média final é: " + mediaFinal.ToString("N1"));

            Console.ReadKey();
        }
    }
}
