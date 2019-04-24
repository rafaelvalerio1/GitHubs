using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2) Escreva um Programa em C# para ler o número total de eleitores de um município, o número de votos brancos, nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao total de eleitores. */

            int totEleitores, votosBrancos, votosNulos, votosValidos, somaVotos;
            double porcentagemVotosBrancos, porcentagemVotosNulos, porcentagemVotosValidos;

            Console.Write("Digite o número total de ELEITORES: ");
            totEleitores = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número total de VOTOS BRANCOS: ");
            votosBrancos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número total de VOTOS NULOS: ");
            votosNulos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número total de VOTOS VÁLIDOS: ");
            votosValidos = Convert.ToInt32(Console.ReadLine());

            somaVotos = votosBrancos + votosNulos + votosValidos;

            if(somaVotos > totEleitores)
            {
                Console.WriteLine("O número de votos não corresponde ao total de eleitores");
            }
            else if(totEleitores > somaVotos)
            {
                Console.WriteLine("O número de eleitores não corresponde ao total de votos");
            }
            else if(somaVotos == totEleitores)
            {
                porcentagemVotosBrancos = (Convert.ToDouble(votosBrancos) / Convert.ToDouble(totEleitores)) * 100;
                porcentagemVotosNulos = (Convert.ToDouble(votosNulos) / Convert.ToDouble(totEleitores)) * 100;
                porcentagemVotosValidos = (Convert.ToDouble(votosValidos) / Convert.ToDouble(totEleitores)) * 100;

                Console.WriteLine("\n------ELEITORES------");
                Console.WriteLine("Total: " + totEleitores);

                Console.WriteLine("\n------VOTOS BRANCOS------");
                Console.WriteLine("Total: " + votosBrancos);
                Console.WriteLine("Porcentagem: " + porcentagemVotosBrancos + "%");

                Console.WriteLine("\n------VOTOS NULOS------");
                Console.WriteLine("Total: " + votosNulos);
                Console.WriteLine("Porcentagem: " + porcentagemVotosNulos + "%");

                Console.WriteLine("\n------VOTOS VÁLIDOS------");
                Console.WriteLine("Total: " + votosValidos);
                Console.WriteLine("Porcentagem: " + porcentagemVotosValidos + "%");
            }
            else
            {
                Console.WriteLine("Dados Inválidos");
            }
            Console.ReadKey();
        }
    }
}
