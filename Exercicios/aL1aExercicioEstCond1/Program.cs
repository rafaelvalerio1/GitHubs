using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1aExercicioEstCond1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;

            Console.Write("Digite a sua nota: ");
            nota = Convert.ToDouble(Console.ReadLine());

            if(nota<=4)
            {
                Console.WriteLine("Aluno REPROVADO");
            }
            else if(nota >= 5)
            {
                Console.WriteLine("Aluno APROVADO");
            }
            else
            {
                Console.WriteLine("Digite a nota de 1 a 10");
            }
            Console.ReadKey();
        }
    }
}
