using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6) Escreva um Programa em C# para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor correspondente em graus Celsius (baseado na fórmula abaixo):  
                    C               F - 32                        
                ---------    =   ------------
                    5                 9
            Observação: Para testar se a sua resposta está correta saiba que 100ºC = 212ºF  */

            int opcao;
            double valorFah, valorCel, formulaFah, formulaCel, grausFah, grausCel;

            do
            {
                Console.Write("\n------------CONVERSÃO DE TEMPERATURA-----------\n");
                Console.Write("1 - Converter de Fahrenheit para Celsius \n2 - Converter de Celsius para Fahrenheit \n3 - Sair do Programa\n");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o valor em Fahrenheit para converter em Celsius: ");
                        valorFah = Convert.ToDouble(Console.ReadLine());
                        formulaFah = valorFah - 32;
                        grausCel = (formulaFah * 5) / 9;
                        Console.WriteLine(valorFah + " °F é igual a: " + grausCel + " °C");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Digite o valor em Celsius para converter em Fahrenheit: ");
                        valorCel = Convert.ToDouble(Console.ReadLine());
                        formulaCel = valorCel / 5;
                        grausFah = (formulaCel * 9) + 32;
                        Console.WriteLine(valorCel + " °C é igual a: " + grausFah + " °F");
                        break;
                    case 3:
                        Console.WriteLine("Saindo do Programa...");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while(opcao!=3);  
        }
    }
}
