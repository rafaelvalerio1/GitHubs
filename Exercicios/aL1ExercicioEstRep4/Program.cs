using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioEstRep4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crie um Algoritmo que leia 5 nomes e depois exiba os nomes na forma em que foram lidos.
                • Estruturapara*/

            List<string> listaNomes = new List<string>();
            string nome;

            do
            {
                Console.Write("Digite um nome: ");
                nome = Console.ReadLine();

                listaNomes.Add(nome);

                Console.WriteLine("Mais alguma coisa? Digite sim ou [enter] para não");
            } while (!string.IsNullOrEmpty(Console.ReadLine()));

            //Deixa lista em ordem alfabética 
            listaNomes.Sort();

            Console.WriteLine("\n============* LISTA DE NOMES *============");
            Console.WriteLine($"Foram digitados {listaNomes.Count} nomes:");

            //Exibe os itens do pedido com os preços
            for (int i = 0; i < listaNomes.Count; i++)
            {
                Console.WriteLine($"Nome {i+1}: = {listaNomes[i]}");
            }

            Console.ReadKey();
        }
    }
}
