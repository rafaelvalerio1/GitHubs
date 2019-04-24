using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Camaro camaro1 = new Camaro("Fiat", "2010", 4, "75cv", "Flex", false, 14, "Fire");
            Veiculo veiculo2 = new Veiculo("Ford", "2019", 2, "466cv a 7.000rpm", "Flex", true, 19, "GT Premium 5.0 V8");

            Console.WriteLine("========* CARRO: PÁLIO *========");
            Console.WriteLine($"Marca: {camaro1.Marca}");
            Console.WriteLine($"Modelo: {camaro1.Modelo}");
            Console.WriteLine($"Quantidade de Portas: {camaro1.QtdPortas}");
            Console.WriteLine($"Potência: {camaro1.Potencia}");
            Console.WriteLine($"Combustível: {camaro1.Combustivel}");
            Console.WriteLine($"Possui câmbio automático? {camaro1.CambioAutomatico}");
            Console.WriteLine($"Tamanho do aro: {camaro1.AroRodas}");
            Console.WriteLine($"Versão: {camaro1.Versao}");

            Console.WriteLine("\n\n========* CARRO: MUSTANG *========");
            Console.WriteLine($"Marca: {veiculo2.Marca}");
            Console.WriteLine($"Modelo: {veiculo2.Modelo}");
            Console.WriteLine($"Quantidade de Portas: {veiculo2.QtdPortas}");
            Console.WriteLine($"Potência: {veiculo2.Potencia}");
            Console.WriteLine($"Combustível: {veiculo2.Combustivel}");
            Console.WriteLine($"Possui câmbio automático? {veiculo2.CambioAutomatico}");
            Console.WriteLine($"Tamanho do aro: {veiculo2.AroRodas}");
            Console.WriteLine($"Versão: {veiculo2.Versao}");
            Console.ReadKey();
        }
    }
}
