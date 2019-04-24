using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo();

            Console.Write("Digite a largura (comprimento) do retângulo: ");
            retangulo1.Largura = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite a altura do retângulo: ");
            retangulo1.Altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"A área desse retângulo é igual a: {retangulo1.CalcularArea(retangulo1.Largura, retangulo1.Altura)}");
            Console.ReadKey();
        }
    }
}
