using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1bExercicioEstCond11_1
{
    /*11) Elabore um Programa em C# que leia o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa. Sabendo-se que ele recebe uma comissão de 3% sobre o total das vendas até R$ 1.500,00 mais 5% sobre o que ultrapassar este valor, calcular e escrever o seu salário total. */
    public class SalarioVendedor
    {
        double salarioFixo, vendas;

        public double SalarioFixo
        {
            get { return salarioFixo; }
            set { salarioFixo = value; }
        }
        public double Vendas
        {
            get { return vendas; }
            set { vendas = value; }
        }

        public double VerificarSalario(double vendas, double salario)
        {
            double salarioFinal = 0.0;
            if(vendas<=1500)
            {
                salarioFinal = (vendas * 0.03) + salario;
            }
            else if(vendas>1500)
            {
                salarioFinal = (vendas * 0.08) + salario;
            }
            return salarioFinal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SalarioVendedor vendedor1 = new SalarioVendedor();

            Console.Write("Digite o valor do salário: R$ ");
            vendedor1.SalarioFixo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor total das vendas do mês: R$ ");
            vendedor1.Vendas = Convert.ToDouble(Console.ReadLine());
    
            Console.WriteLine("O Salário Final é igual a: R$ {0}", vendedor1.VerificarSalario(vendedor1.Vendas, vendedor1.SalarioFixo));
  
            Console.ReadKey();
        }
    }
}
