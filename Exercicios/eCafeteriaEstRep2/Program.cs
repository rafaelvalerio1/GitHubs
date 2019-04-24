using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCafeteriaEstRep2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pedido;  
            double preco;
            List<string> listaPedido = new List<string>();
            List<double> listaPreco = new List<double>();

            do
            {
                Console.Write("\n------CAFETERIA SENAC------\n");
                Console.Write("O que você gostaria? R: ");
                pedido = Console.ReadLine();

                Console.Write("Qual é o preço? R: R$ ");
                preco = Convert.ToDouble(Console.ReadLine());

                //Adiciona o item à lista
                listaPedido.Add(pedido);
                listaPreco.Add(preco);

                Console.WriteLine("Mais alguma coisa? Digite sim ou [enter] para não");
            } while (!string.IsNullOrEmpty(Console.ReadLine()));

            //Somando os valores da listaPreco
            double y = 0;
            listaPreco.ForEach(x => y += x);

            //Ordena a lista 
            listaPedido.Sort();
            Console.WriteLine("\n============CUPOM FISCAL============");
            Console.WriteLine($"O cupom Fiscal tem {listaPedido.Count} pedidos:");

            //Exibe os itens do pedido com os preços
            for (int i = 0; i < listaPedido.Count; i++)
            {
                Console.WriteLine($"{listaPedido[i]} = R$ {listaPreco[i].ToString("N2")}");
            }
 
            //Exibe o preço total dos pedidos
            Console.WriteLine($"\nTotal = R$ {y.ToString("N2")}");

            Console.ReadKey();
        }
    }
}
