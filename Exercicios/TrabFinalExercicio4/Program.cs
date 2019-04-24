using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio4
{
    /*4. Ler dois valores para as variáveis A e B, e efetuar as trocas dos valores de forma que a variável A passe a possuir o valor da variável B e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados. */
    class Program
    {
        class InverterValor
        {
            double valorA, valorB;

            public double ValorA
            {
                get { return valorA; }
                set { valorA = value; }
            }
            public double ValorB
            {
                get { return valorB; }
                set { valorB = value; }
            }

            public double TrocarValor(double v1, double v2)
            {
                v1 = v2;
                return v1;
            }
        }
        static void Main(string[] args)
        {
            InverterValor inversao1 = new InverterValor();

            Console.Write("\nDigite o valor (numérico) da variável A: ");
            inversao1.ValorA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor (numérico) da variável B: ");
            inversao1.ValorB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n========================================");
            Console.WriteLine($"O novo valor de A é: {inversao1.TrocarValor(inversao1.ValorA, inversao1.ValorB)}");
            Console.WriteLine($"O novo valor de B é: {inversao1.TrocarValor(inversao1.ValorB, inversao1.ValorA)}");
            Console.WriteLine("========================================");
            Console.ReadKey();
        }
    }
}
