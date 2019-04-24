using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace aHeranca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            ContaEmpresa contaEmpresa1 = new ContaEmpresa();
            ContaPoupanca contaPoupanca1 = new ContaPoupanca();

            //conta1.Deposita(500.0);
            //contaPoupanca1.Saldo = 100.0;
            //contaPoupanca1.Saldo = 100.0;
            //contaPoupanca1.Saca(30.0);

            //Console.WriteLine($"O saldo atual é : R$ {contaPoupanca1.Saldo.ToString("N2")}");
            //Console.ReadKey();

            bool repeticao = true;
            int opcao2;
            while (repeticao)
            {
                Console.Write("\nDigite 1 para Conta Corrente\nDigite 2 para Conta Poupança\nDigite 3 para Conta Empresa: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        Console.Write("\nInforme o valor do Saldo: U$ ");
                        conta1.Saldo = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite 1 para sacar\nDigite 2 para depositar\n Digite 3 para sair: ");
                        opcao2 = Convert.ToInt32(Console.ReadLine());
                        if (opcao2 == 1)
                        {
                            Console.Write("Informe o valor do saque: U$ ");
                            double sacar = Convert.ToDouble(Console.ReadLine());
                            conta1.Saca(sacar);
                            Console.WriteLine($"O valor do seu saldo é: U$ {conta1.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                        else if (opcao2 == 2)
                        {
                            Console.Write("Informe o valor do depósito: U$ ");
                            double deposito = Convert.ToDouble(Console.ReadLine());
                        }
                        else if(opcao2 == 3)
                        {
                            repeticao = false;
                        }
                        else
                        {
                            Console.WriteLine("Dados Inválidos");
                        }
                        break;
                    case 2:
                        Console.Write("\nInforme o valor do Saldo: U$ ");
                        contaPoupanca1.Saldo = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite 1 para sacar\nDigite 2 para sair: ");
                        opcao2 = Convert.ToInt32(Console.ReadLine());
                        if (opcao2 == 1)
                        {
                            Console.Write("Informe o valor do saque: U$ ");
                            double sacar = Convert.ToDouble(Console.ReadLine());
                            contaPoupanca1.Saca(sacar);
                            Console.WriteLine($"O valor do seu saldo é: U$ {contaPoupanca1.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                        else if (opcao2 == 2)
                        {
                            repeticao = false;
                        }
                        else
                        {
                            Console.WriteLine("Dados Inválidos");
                        }
                        break;
                    case 3:
                        Console.Write("\nInforme o valor do Saldo: U$ ");
                        conta1.Saldo = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite 1 para sacar\nDigite 2 para depositar\n Digite 3 para sair: ");
                        opcao2 = Convert.ToInt32(Console.ReadLine());
                        if (opcao2 == 1)
                        {
                            Console.Write("Informe o valor do saque: U$ ");
                            double sacar = Convert.ToDouble(Console.ReadLine());
                            contaPoupanca1.Saca(sacar);
                            Console.WriteLine($"O valor do seu saldo é: U$ {conta1.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                        else if (opcao2 == 2)
                        {
                            Console.Write("Informe o valor do depósito: U$ ");
                            double deposito = Convert.ToDouble(Console.ReadLine());
                        }
                        else if (opcao2 == 3)
                        {
                            repeticao = false;
                        }
                        else
                        {
                            Console.WriteLine("Dados Inválidos");
                        }
                        break;
                }

                Console.Write("Deseja continuar realizando operações financeiras? [s/n]: ");
                char opcao3 = Char.Parse(Console.ReadLine());
                if(opcao3 != 'S' && opcao3 != 's')
                {
                    repeticao = false;
                }
                Console.ReadKey();
            }
        }
    }
}
