using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Equacao equacao1 = new Equacao();

            Console.Write("Digite o valor de a: ");
            equacao1.A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            equacao1.B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de c: ");
            equacao1.C = Convert.ToDouble(Console.ReadLine());

            if(equacao1.CalcularDelta(equacao1.A, equacao1.B, equacao1.C) >= 0)
            {    
                if(equacao1.CalcularRaiz(equacao1.A, equacao1.B, equacao1.C, '+') == equacao1.CalcularRaiz(equacao1.A, equacao1.B, equacao1.C, '-'))
                {
                    Console.WriteLine($"A raiz vale: {equacao1.CalcularRaiz(equacao1.A, equacao1.B, equacao1.C, '+')}");
                }
                else
                {
                    Console.WriteLine($"As raízes são X¹ = {equacao1.CalcularRaiz(equacao1.A, equacao1.B, equacao1.C, '+')} e X² = {equacao1.CalcularRaiz(equacao1.A, equacao1.B, equacao1.C, '-')}");
                }
            }
            else if(equacao1.CalcularDelta(equacao1.A, equacao1.B, equacao1.C) < 0)
            {
                Console.WriteLine($"A função não possui raízes reais... O valor do delta é igual a: {equacao1.CalcularDelta(equacao1.A, equacao1.B, equacao1.C)}");
            }
            Console.ReadKey();
        }
    }
}
