using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6. A concessionária de veículos CARANGO VELHO está vendendo os seus veículos com desconto. Faça um algoritmo que calcule e exiba o valor do desconto e o valor a ser pago pelo cliente de vários carros. O desconto deverá ser calculado de acordo com o ano do veículo. Até 2015 => 12% e acima de 2015 => 7%. O sistema deverá perguntar se deseja continuar calculando desconto até que a resposta seja: N.  Informar o número total de carros calculados com ano até 2015 e total geral.  Utilize estruturas de repetição: */

            Carro carro1 = new Carro();

            List<float> listaValorCarro = new List<float>();
            List<int> listaAnoCarro = new List<int>();
            bool repeticao = true;
            int i = 1;

            while (repeticao)
            {
                Console.WriteLine($"\n=============* CARRO {i} *=============");
                Console.Write("Digite o valor do carro: R$ ");
                carro1.ValorCarro = Convert.ToSingle(Console.ReadLine());
                Console.Write("Digite o ano do carro: ");
                carro1.AnoCarro = Convert.ToInt32(Console.ReadLine());
                Console.Write($"===================================");

                listaValorCarro.Add(carro1.ValorCarro);
                listaAnoCarro.Add(carro1.AnoCarro);

                Console.Write("\nDeseja continuar calculando? [s/n]: ");
                char opcao = Char.Parse(Console.ReadLine());
                i++;
                if (opcao!='S' && opcao!='s')
                {
                    repeticao = false;
                }
            }

            Console.WriteLine("\n");
            for(int j=0; j<listaValorCarro.Count; j++)
            {
                Console.WriteLine($"\n=============* CARRO {j+1} *=============");
                Console.WriteLine($"O valor do carro com desconto é de: R$ {carro1.CalcularDescontoCarro(listaValorCarro, listaAnoCarro, j).ToString("N2")}");
            }
            Console.WriteLine($"\nForam calculados {carro1.NumCarrosAte2015(listaAnoCarro)} carro(s) com ano até 2015");
            Console.WriteLine($"Total geral de carros: {carro1.NumCarrosTotalGeral(listaAnoCarro)}");

            Console.ReadKey();

        }
    }
}
