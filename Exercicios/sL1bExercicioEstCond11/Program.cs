using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1bExercicioEstCond11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*11) Elabore um Programa em C# que leia o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa. Sabendo-se que ele recebe uma comissão de 3% sobre o total das vendas até R$ 1.500,00 mais 5% sobre o que ultrapassar este valor, calcular e escrever o seu salário total. */

            double salarioFixo, vendas, salarioFinal;

            Console.Write("Digite o valor do salário: R$ ");
            salarioFixo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor total das vendas do mês: R$ ");
            vendas = Convert.ToDouble(Console.ReadLine());

            if(vendas<=1500)
            {
                salarioFinal = (vendas * 0.03) + salarioFixo;
                Console.WriteLine("O Salário Final é igual a: R$ {0}", salarioFinal);
            }
            else if(vendas>1500)
            {
                salarioFinal = (vendas * 0.08) + salarioFixo;
                Console.WriteLine("O Salário Final é igual a: R$ {0}", salarioFinal);
            }
            else
            {
                Console.WriteLine("Dados Inválidos");
            }
            Console.ReadKey();
        }
    }
}
