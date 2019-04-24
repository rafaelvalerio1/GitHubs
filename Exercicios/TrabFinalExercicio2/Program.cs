using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Escrever um algoritmo que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o seu nome, o salário fixo e salário no final do mês: */

            Vendedor vendedor1 = new Vendedor();

            //Lendo os Valores
            Console.WriteLine("\n<><><><><> SISTEMA DE GESTÃO DE VENDEDORES <><><><><>");
            Console.Write(">>> Digite o nome do vendedor: ");
            vendedor1.Nome = Console.ReadLine();
            Console.Write(">>> Digite o salario: R$ ");
            vendedor1.Salario = Convert.ToDouble(Console.ReadLine());
            Console.Write(">>> Digite o total das vendas efetuadas pelo vendedor no mês: R$ ");
            vendedor1.ValorVendas = Convert.ToInt32(Console.ReadLine());

            //Exibindo os valores
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>> RESUMO <<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine($"-- Nome: {vendedor1.Nome}");
            Console.WriteLine($"-- Salário: R$ {vendedor1.Salario.ToString("N2")}");
            Console.WriteLine($"-- Salário Final (salário + comissão): R$ {vendedor1.RetornarComissao(vendedor1.Salario, 0.15).ToString("N2")}");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>><><><><><><><><><<<<<<<<<<<<<<<<<");
            Console.ReadKey();

        }
    }
}
