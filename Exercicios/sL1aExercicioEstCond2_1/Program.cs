using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond2_1
{
    /*2) Escreva um Programa em C# para ler o número total de eleitores de um município, o número de votos brancos, nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao total de eleitores. */
    public class VotosEleitores
    {
        int totEleitores, votosBrancos, votosNulos, votosValidos;

        public int TotEleitores
        {
            get { return totEleitores; }

            set { totEleitores = value; }
        }
        public int VotosBrancos
        {
            get { return votosBrancos; }

            set { votosBrancos = value; }
        }
        public int VotosNulos
        {
            get { return votosNulos; }

            set { votosNulos = value; }
        }
        public int VotosValidos
        {
            get { return votosValidos; }

            set { votosValidos = value; }
        }
        public int SomaVotos(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public double PorcentagemVotos(double valor, int total)
        {
            double porcentagemVotos;
            porcentagemVotos = (Convert.ToDouble(valor) / Convert.ToDouble(total)) * 100;
            return porcentagemVotos;
        }
        public void Verificacao()
        {
            if (SomaVotos(VotosBrancos, VotosNulos, VotosValidos) > TotEleitores)
            {
                Console.WriteLine("O número de votos não corresponde ao total de eleitores");
            }
            else if (TotEleitores > SomaVotos(VotosBrancos, VotosNulos, VotosValidos))
            {
                Console.WriteLine("O número de eleitores não corresponde ao total de votos");
            }
            else if (SomaVotos(VotosBrancos, VotosNulos, VotosValidos) == TotEleitores)
            {
                Console.WriteLine("\n------ELEITORES------");
                Console.WriteLine("Total: " + TotEleitores);

                Console.WriteLine("\n------VOTOS BRANCOS------");
                Console.WriteLine("Total: " + VotosBrancos);
                Console.WriteLine("Porcentagem: " + PorcentagemVotos(VotosBrancos, TotEleitores) + "%");

                Console.WriteLine("\n------VOTOS NULOS------");
                Console.WriteLine("Total: " + VotosNulos);
                Console.WriteLine("Porcentagem: " + PorcentagemVotos(VotosNulos, TotEleitores) + "%");

                Console.WriteLine("\n------VOTOS VÁLIDOS------");
                Console.WriteLine("Total: " + VotosValidos);
                Console.WriteLine("Porcentagem: " + PorcentagemVotos(VotosValidos, TotEleitores) + "%");
            }
            else
            {
                Console.WriteLine("Dados Inválidos");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            VotosEleitores eleitor1 = new VotosEleitores();

            Console.Write("Digite o número total de ELEITORES: ");
            eleitor1.TotEleitores = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número total de VOTOS BRANCOS: ");
            eleitor1.VotosBrancos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número total de VOTOS NULOS: ");
            eleitor1.VotosNulos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número total de VOTOS VÁLIDOS: ");
            eleitor1.VotosValidos = Convert.ToInt32(Console.ReadLine());

            eleitor1.Verificacao();

            Console.ReadKey();
        }
    }
}
