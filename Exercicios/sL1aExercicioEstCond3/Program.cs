using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3) Escreva um Programa em C# para ler o salário mensal atual de um funcionário e o percentual de reajuste. Calcular e escrever o valor do novo salário.*/

            double salario, reajuste, novoSalario;

            Console.Write("Digite o valor do salário mensal: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do reajuste (%): ");
            reajuste = Convert.ToDouble(Console.ReadLine());

            novoSalario = (salario * (reajuste / 100)) + salario;

            Console.WriteLine("O salário com reajuste de " + reajuste + "% " + "é igual a R$ " + novoSalario.ToString("N2"));

            Console.ReadKey();
        }
    }
}
