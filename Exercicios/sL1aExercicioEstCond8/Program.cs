using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8) As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem compradas pelo menos 12. Escreva um Programa em C# que leia o número de maçãs compradas, calcule e escreva o custo total da compra. */

            int numMacaCompradas;
            double precoMaca, total;

            Console.Write("\n---------CÁLCULO DO PREÇO DAS MAÇÃS---------\n");
            Console.Write("Digite o número de maçãs compradas: ");
            numMacaCompradas = Convert.ToInt32(Console.ReadLine());

            if (numMacaCompradas < 12)
            {
                precoMaca = 1.3;
                total = numMacaCompradas * precoMaca;
                Console.WriteLine("Você comprou um total de " + numMacaCompradas + " maçãs que vão custar R$ " + precoMaca.ToString("N2") + " a unidade. O total da compra é igual a: " + total.ToString("N2"));
            }
            else if (numMacaCompradas >= 12)
            {
                precoMaca = 1.0;
                total = numMacaCompradas * precoMaca;
                Console.WriteLine("Você comprou um total de " + numMacaCompradas + " maçãs que vão custar R$ " + precoMaca.ToString("N2") + " a unidade. O total da compra é igual a: " + total.ToString("N2"));
            }
            Console.ReadKey();
        }
    }
}
