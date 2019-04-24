using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            string l1 = "-------";
            string l2 = "=======";

            //Lendo os dados
            Console.WriteLine($"\n{l2}{l2}* CADASTRO DAS PESSOAS *{l2}{l2}");
            for (int i=0; i<pessoa1.Nome.Length; i++)
            {
                Console.WriteLine($"\n{l1}{l1} PESSOA {i + 1} {l1}{l1}");
                Console.Write("Digite seu nome: ");
                pessoa1.Nome[i] = Console.ReadLine();
                Console.Write("Digite seu sexo ['m' para Masculino ou 'f' para Feminino]: ");
                pessoa1.Sexo[i] = Char.Parse(Console.ReadLine());
                Console.WriteLine($"{l1}{l1}{l1}{l1}{l1}");
            }
 
            //Exibindo os dados
            Console.WriteLine($"\n\n\n{l2}{l2}* DADOS DAS PESSOAS *{l2}{l2}");
            for (int i = 0; i < pessoa1.Nome.Length; i++)
            {
                Console.WriteLine($"\n{l1} PESSOA {i + 1} {l1}");
                Console.WriteLine($"Nome: {pessoa1.Nome[i]}");
                Console.Write($"Sexo: {pessoa1.InformarSexo(pessoa1.Sexo, i)}");
                Console.WriteLine($"\n{l1}{l1}{l1}");
            }

            Console.WriteLine($"\nTotal de Homens: {pessoa1.RetornarTotalHomens(pessoa1.Sexo)}");
            Console.WriteLine($"Total de Mulheres: {pessoa1.RetornarTotalMulheres(pessoa1.Sexo)}");

            Console.ReadKey();
        }
    }
}
