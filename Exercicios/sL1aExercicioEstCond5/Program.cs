using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5) Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês, mais uma comissão também fixa para cada carro vendido e mais 5% do valor das vendas por ele efetuadas. Escrever um Programa em C# que leia o número de carros por ele vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro vendido. Calcule e escreva o salário final do vendedor. */

            int numCarVendas;
            double salarioFixo, comissaoFixa, valorVendas, salarioFinal, comissaoFinal;

            Console.Write("\n------REVENDEDORA DE CARROS------\n");
            Console.Write("Digite o seu salário fixo: R$ ");
            salarioFixo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a sua comissão fixa (por carro vendido): R$ ");
            comissaoFixa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o número de carros vendidos neste mês: ");
            numCarVendas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor total das vendas: R$ ");
            valorVendas = Convert.ToInt32(Console.ReadLine());

            comissaoFinal = (comissaoFixa * numCarVendas) + (valorVendas * 0.05);
            salarioFinal = salarioFixo + comissaoFinal;

            Console.WriteLine("O seu salário final é de R$ " + salarioFinal.ToString("N2"));

            Console.ReadKey();
        }
    }
}
