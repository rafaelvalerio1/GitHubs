using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4) Criar um Programa em C# que apresente o valor da conversão em dólar de um valor lido em real. O programa deve solicitar o valor da cotação do dólar e também a quantidade de reais disponível com o usuário. */

            double valorReais, cotacao, conversao;

            Console.Write("\n----CONVERSÃO PARA DÓLAR----\n");
            Console.Write("Digite o valor: R$ ");
            valorReais = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor da cotação: ");
            cotacao = Convert.ToDouble(Console.ReadLine());

            conversao = valorReais / cotacao;

            Console.WriteLine("Você possui $ " + conversao.ToString("N2") + " dólares");

            Console.ReadKey();
        }
    }
}
