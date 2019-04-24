using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1aExercicioEstCond5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Criar um algoritmo que informe:
                 Sistema de Boletim Escolar
                 Informar o nome do Aluno
                 Ler as 3 notas (N1, N2 e N3)
                 Calcular a média do Aluno
                 Informar a menção do Aluno:
                • Aprovado >= 7
                • Recuperação = 5.1 a 6.9
                • Reprovado < 5.1
            */

            string nome;
            double n1, n2, n3, media;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua 1ª nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua 2ª nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua 3ª nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            if(media<5.1)
            {
                Console.WriteLine(nome + ", você está reprovado");
            }
            else if(media>=5.1 && media<=6.9)
            {
                Console.WriteLine(nome + ", você está de recuperação");
            }
            else if(media>=7 && media<=10)
            {
                Console.WriteLine(nome + ", você está aprovado");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }

            Console.ReadKey();
        }
    }
}
