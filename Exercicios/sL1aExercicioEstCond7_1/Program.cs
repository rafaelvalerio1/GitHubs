using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond7_1
{
    /*7) Faça um Programa em C# que leia três notas de um aluno, calcule e escreva a média final deste aluno. Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5. Fórmula para o cálculo da média final é: 
             *                     n1 * 2 + n2 * 3 + n3 * 5
               mediafinal =   -----------------------------------      
                                             10                     */
    public class CalcularMedia
    {
        double nota1, nota2, nota3;

        public double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }
        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }
        public double Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }
        public double CalcularMediaNotas(double n1, double n2, double n3, int p1, int p2, int p3)
        {
            int somaPesos = p1 + p2 + p3;
            double mediaFinal;
            mediaFinal = ((n1 * p1) + (n2 * p2) + (n3 * p3)) / somaPesos;
            return mediaFinal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalcularMedia aluno1 = new CalcularMedia();

            Console.Write("\n---------CÁLCULO DA MÉDIA---------\n");
            Console.Write("Digite a 1ª nota: ");
            aluno1.Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a 2ª nota: ");
            aluno1.Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a 3ª nota: ");
            aluno1.Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A sua média final é: " + aluno1.CalcularMediaNotas(aluno1.Nota1, aluno1.Nota2, aluno1.Nota3, 2, 3, 5).ToString("N1"));

            Console.ReadKey();
        }
    }
}
