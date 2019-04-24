using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond5_1
{
    /*5) Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês, mais uma comissão também fixa para cada carro vendido e mais 5% do valor das vendas por ele efetuadas. Escrever um Programa em C# que leia o número de carros por ele vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro vendido. Calcule e escreva o salário final do vendedor. */
    public class Revendedora
    {
        int numCarVendas;
        double salarioFixo, comissaoFixa, valorVendas;

        public int NumCarVendas
        {
            get { return numCarVendas; }
            set { numCarVendas = value; }
        }
        public double SalarioFixo
        {
            get { return salarioFixo; }
            set { salarioFixo = value; }
        }
        public double ComissaoFixa
        {
            get { return comissaoFixa; }
            set { comissaoFixa = value; }
        }
        public double ValorVendas
        {
            get { return valorVendas; }
            set { valorVendas = value; }
        }

        public double SalarioFinal(double comissao, int numCarros, double valorTotalVendas, double salario)
        {
            double comissaoFinal;
            double salarioFinal;
            comissaoFinal = (comissao * numCarros) + (valorTotalVendas * 0.05);
            salarioFinal = salario + comissaoFinal;
            return salarioFinal;
        }
        public void Resultado()
        {
            Console.WriteLine("O seu salário final é de R$ " + SalarioFinal(ComissaoFixa, NumCarVendas, ValorVendas, SalarioFixo).ToString("N2"));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                Revendedora funcionario1 = new Revendedora();

                Console.Write("\n------REVENDEDORA DE CARROS------\n");
                Console.Write("Digite o seu salário fixo: R$ ");
                funcionario1.SalarioFixo = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a sua comissão fixa (por carro vendido): R$ ");
                funcionario1.ComissaoFixa = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o número de carros vendidos neste mês: ");
                funcionario1.NumCarVendas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o valor total das vendas: R$ ");
                funcionario1.ValorVendas = Convert.ToInt32(Console.ReadLine());

            funcionario1.Resultado();

            Console.ReadKey();
        }
    }
}
