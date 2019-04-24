using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            //Lendo os dados
            Console.Write("Digite o nome do aluno: ");
            aluno1.Nome = Console.ReadLine();
            for(int i=0; i<aluno1.Notas.Length; i++)
            {
                Console.Write($"Digite a {i + 1}ª nota: ");
                aluno1.Notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            //Exibindo os dados
            Console.WriteLine($"\n================== {aluno1.Nome} ==================");
            Console.WriteLine($">>>> Média: {aluno1.CalcularMedia(aluno1.Notas).ToString("N2")}");
            Console.WriteLine("======================================================");
            Console.ReadKey();
        }
    }
}
