using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Escrever um algoritmo para determinar o consumo médio de um automóvel sendo fornecida a distância total percorrida pelo automóvel e o total de combustível gasto. */
            Automovel automovel1 = new Automovel();
            Console.Write("==============*  CÁLCULO DE CONSUMO MÉDIO DE COMBUSTÍVEL *==============");
            Console.Write("\nDigite a distância percorrida: ");
            automovel1.Distancia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o combustível gasto: ");
            automovel1.Consumo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"O consumo médio de combustível do seu veículo é: {automovel1.ConsumoMedio(automovel1.Distancia, automovel1.Consumo)}");
            Console.ReadKey();
        }
    }
}
