using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond3_1
{
    /*3) Escreva um Programa em C# para ler o salário mensal atual de um funcionário e o percentual de reajuste. Calcular e escrever o valor do novo salário.*/
    public class SalarioFuncionario
    {
        double salario, reajuste;

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public double Reajuste
        {
            get { return reajuste; }
            set { reajuste = value; }
        }
        public double ValorReajustado(double valor, double porcentagem)
        {
            double valorReajustado;
            valorReajustado = (valor * (porcentagem / 100)) + valor;
            return valorReajustado;
        }
        public void Resultado()
        {
            Console.WriteLine("O salário com reajuste de " + Reajuste + "% " + "é igual a R$ " + ValorReajustado(Salario, Reajuste).ToString("N2"));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SalarioFuncionario funcionario1 = new SalarioFuncionario();

            Console.Write("Digite o valor do salário mensal: ");
            funcionario1.Salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do reajuste (%): ");
            funcionario1.Reajuste = Convert.ToDouble(Console.ReadLine());

            funcionario1.Resultado();

            Console.ReadKey();
        }
    }
}
