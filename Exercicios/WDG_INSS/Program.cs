using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDG_INSS
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoINSS calculo1 = new CalculoINSS();

            Console.Write("Digite seu salário: ");
            calculo1.Salario = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ano para calcular o desconto do INSS:\nDigite 1 para 2011\nDigite 2 para 2012:");
            calculo1.Opcao = Convert.ToInt32(Console.ReadLine());

            calculo1.Resultado();

            Console.ReadKey();
        }
    }
}
