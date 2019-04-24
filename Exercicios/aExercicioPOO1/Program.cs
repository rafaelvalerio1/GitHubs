using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aExercicioPOO1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instância
            Contas contas1 = new Contas();

            Console.Write("Digite o 1º número: ");
            contas1.Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 2º número: ");
            contas1.Numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A soma é: {contas1.Somar(contas1.Numero1, contas1.Numero2)}");
            Console.ReadKey();
        }
    }
}
