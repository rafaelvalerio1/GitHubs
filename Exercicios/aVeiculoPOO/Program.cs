using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aVeiculoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo1 = new Veiculo();

            Console.Write("Digite a cor do veículo: ");
            veiculo1.Cor = Console.ReadLine();
            Console.Write("Digite o modelo do veículo: ");
            veiculo1.Modelo = Console.ReadLine();
            Console.Write("Digite a marca do veículo: ");
            veiculo1.Marca = Console.ReadLine();
            Console.Write("Digite o motor do veículo: ");
            veiculo1.Motor = Console.ReadLine();
            Console.Write("Digite o chassi do veículo: ");
            veiculo1.Chassi = Console.ReadLine();
            Console.Write("Digite a quantidade de rodas do veículo: ");
            veiculo1.Roda = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n\n=====* DADOS DO VEÍCULO *=====");
            Console.WriteLine($"Cor: {veiculo1.Cor}");
            Console.WriteLine($"Modelo: {veiculo1.Modelo}");
            Console.WriteLine($"Marca: {veiculo1.Marca}");
            Console.WriteLine($"Motor: {veiculo1.Motor}");
            Console.WriteLine($"Chassi: {veiculo1.Chassi}");
            Console.WriteLine($"Rodas: {veiculo1.Roda}");

            Console.ReadKey();
        }
    }
}
