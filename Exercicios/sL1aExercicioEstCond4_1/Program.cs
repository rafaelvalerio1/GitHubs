using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond4_1
{
    /*4) Criar um Programa em C# que apresente o valor da conversão em dólar de um valor lido em real. O programa deve solicitar o valor da cotação do dólar e também a quantidade de reais disponível com o usuário. */
    public class Cotacao
    {
        double valorReais, cotacaoDolar;

        public double ValorReais
        {
            get { return valorReais; }
            set { valorReais = value; }
        }
        public double CotacaoDolar
        {
            get { return cotacaoDolar; }
            set { cotacaoDolar = value; }
        }

        public double Conversao(double valor, double cotacao)
        {
            double conversao;
            conversao = valor / cotacao;
            return conversao;
        }
        public void ResultadoCotacaoRealParaDolar()
        {
            Console.WriteLine("Você possui $ {0} dólares", Conversao(ValorReais, CotacaoDolar).ToString("N2"));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cotacao cotacao1 = new Cotacao();

            Console.Write("\n----CONVERSÃO PARA DÓLAR----\n");
            Console.Write("Digite o valor: R$ ");
            cotacao1.ValorReais = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor da cotação: ");
            cotacao1.CotacaoDolar = Convert.ToDouble(Console.ReadLine());

            cotacao1.ResultadoCotacaoRealParaDolar();

            Console.ReadKey();
        }
    }
}
