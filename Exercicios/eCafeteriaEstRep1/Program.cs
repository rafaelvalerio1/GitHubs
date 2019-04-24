using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCafeteriaEstRep1
{
    class Program
    {
        static void Main(string[] args)
        {
            string preco, pedido;
            string cupomFiscal = "=== Cupom Fiscal ===";
            double precoTotal = 0;

            do
            {
                Console.Write("\n------eCafeteriaEstRep1 SENAC------\n");
                Console.Write("O que você gostaria? R: ");
                pedido = Console.ReadLine();

                Console.Write("Qual é o preço? R: R$ ");
                preco = Console.ReadLine();

                cupomFiscal += $"\n{pedido}\t{preco}";
                precoTotal += Convert.ToDouble(preco);

                Console.WriteLine("Mais alguma coisa? Digite sim ou [enter] para não");
            } while (!string.IsNullOrEmpty(Console.ReadLine()));

            Console.WriteLine(cupomFiscal);
            Console.WriteLine("Total: {0}", precoTotal);
            Console.ReadKey();
        }
    }
}
