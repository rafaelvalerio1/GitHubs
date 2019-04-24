using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond6_1
{
    /*6) Escreva um Programa em C# para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor correspondente em graus Celsius (baseado na fórmula abaixo):  
                    C               F - 32                        
                ---------    =   ------------
                    5                 9
            Observação: Para testar se a sua resposta está correta saiba que 100ºC = 212ºF  */
    public class ConversaoTemperatura
    {
        int opcao;
        double valorFah, valorCel;

        public int Opcao
        {
            get { return opcao; }
            set { opcao = value; }
        }
        public double ValorFah
        {
            get { return valorFah; }
            set { valorFah = value; }
        }
        public double ValorCel
        {
            get { return valorCel; }
            set { valorCel = value; }
        }

        public double Converter(int opcaoTemp, double valor)
        {
            double formulaFah, formulaCel;
            double retornoConv = 0.0;
            if (opcaoTemp==1)
            {
                formulaFah = valor - 32;
                retornoConv = (formulaFah * 5) / 9;
            }
            else if(opcaoTemp==2)
            {
                formulaCel = valor / 5;
                retornoConv = (formulaCel * 9) + 32;
            }
            return retornoConv;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConversaoTemperatura conversao1 = new ConversaoTemperatura();

            do
            {
                Console.Write("\n------------CONVERSÃO DE TEMPERATURA-----------\n");
                Console.Write("1 - Converter de Fahrenheit para Celsius \n2 - Converter de Celsius para Fahrenheit \n3 - Sair do Programa\n");
                conversao1.Opcao = Convert.ToInt32(Console.ReadLine());

                switch (conversao1.Opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o valor em Fahrenheit para converter em Celsius: ");
                        conversao1.ValorFah = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(conversao1.ValorFah + " °F é igual a: " + conversao1.Converter(conversao1.Opcao, conversao1.ValorFah) + " °C");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Digite o valor em Celsius para converter em Fahrenheit: ");
                        conversao1.ValorCel = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(conversao1.ValorCel + " °C é igual a: " + conversao1.Converter(conversao1.Opcao, conversao1.ValorCel) + " °F");
                        break;
                    case 3:
                        Console.WriteLine("Saindo do Programa...");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (conversao1.Opcao != 3);
        }
    }
}
