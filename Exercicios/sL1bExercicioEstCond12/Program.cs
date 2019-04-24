using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1bExercicioEstCond12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*12) Faça um Programa em C# para ler: número da conta do cliente, saldo, débito e crédito. Após, calcular e escrever o saldo atual (saldo atual = saldo - débito + crédito). Também testar se saldo atual for maior ou igual a zero escrever a mensagem 'Saldo Positivo', senão escrever a mensagem 'Saldo Negativo' */

            string numeroConta;
            double saldo, debito, credito, saldoAtual;

            Console.Write("Digite o número da conta: ");
            numeroConta = Console.ReadLine();
            Console.Write("Digite o saldo: ");
            saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor a ser debitado: ");
            debito = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor a ser creditado: ");
            credito = Convert.ToDouble(Console.ReadLine());

            saldoAtual = (saldo - debito) + credito;

            if(saldoAtual>=0)
            {
                Console.WriteLine("O seu saldo é de R$ {0}, portando é POSITIVO", saldoAtual.ToString("N2"));
            }
            else if(saldoAtual<0)
            {
                Console.WriteLine("O seu saldo é de R$ {0}, portando é NEGATIVO", saldoAtual.ToString("N2"));
            }
            else
            {
                Console.WriteLine("Dados Inválidos");
            }
            Console.ReadKey();
        }
    }
}
