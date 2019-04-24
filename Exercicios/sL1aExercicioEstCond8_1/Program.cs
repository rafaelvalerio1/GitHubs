using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond8_1
{
    /*8) As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem compradas pelo menos 12. Escreva um Programa em C# que leia o número de maçãs compradas, calcule e escreva o custo total da compra. */
    public class Maca
    {
        int numMacasCompradas;
        public int NumMacasCompradas
        {
            get { return numMacasCompradas; }

            set { numMacasCompradas = value; }
        }
        public double RetornarPreco()
        {
            double preco = 0.0;

            if(NumMacasCompradas<12)
            {
                preco = 1.3;
            }
            else if(NumMacasCompradas>=12)
            {
                preco = 1.0;
            }
            return preco;
        }
        public void Resultado()
        {
            double total;
            total = NumMacasCompradas * RetornarPreco();
            Console.WriteLine("Você comprou um total de " + NumMacasCompradas + " maçãs que vão custar R$ " + RetornarPreco().ToString("N2") + " a unidade. O total da compra é igual a: " + total.ToString("N2"));
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Maca maca1 = new Maca();

            Console.Write("\n---------CÁLCULO DO PREÇO DAS MAÇÃS---------\n");
            Console.Write("Digite o número de maçãs compradas: ");
            maca1.NumMacasCompradas = Convert.ToInt32(Console.ReadLine());

            maca1.Resultado();
            Console.ReadKey();
        }     
    }
}
