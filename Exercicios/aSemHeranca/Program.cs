using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aSemHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Palio palio1 = new Palio("Fiat", "2010", 4, "75cv", "Flex", false, 14, "Fire");
            Mustang mustang1 = new Mustang("Ford", "2019", 2, "466cv a 7.000rpm", "Flex", true, 19, "GT Premium 5.0 V8");

            Console.WriteLine("========* CARRO: PÁLIO *========");
            Console.WriteLine($"Marca: {palio1.Marca}");
            Console.WriteLine($"Modelo: {palio1.Modelo}");
            Console.WriteLine($"Quantidade de Portas: {palio1.QtdPortas}");
            Console.WriteLine($"Potência: {palio1.Potencia}");
            Console.WriteLine($"Combustível: {palio1.Combustivel}");
            Console.WriteLine($"Possui câmbio automático? {palio1.CambioAutomatico}");
            Console.WriteLine($"Tamanho do aro: {palio1.AroRodas}");
            Console.WriteLine($"Versão: {palio1.Versao}");

            Console.WriteLine("\n\n========* CARRO: MUSTANG *========");
            Console.WriteLine($"Marca: {mustang1.Marca}");
            Console.WriteLine($"Modelo: {mustang1.Modelo}");
            Console.WriteLine($"Quantidade de Portas: {mustang1.QtdPortas}");
            Console.WriteLine($"Potência: {mustang1.Potencia}");
            Console.WriteLine($"Combustível: {mustang1.Combustivel}");
            Console.WriteLine($"Possui câmbio automático? {mustang1.CambioAutomatico}");
            Console.WriteLine($"Tamanho do aro: {mustang1.AroRodas}");
            Console.WriteLine($"Versão: {mustang1.Versao}");
            Console.ReadKey();
        }
    }
}
