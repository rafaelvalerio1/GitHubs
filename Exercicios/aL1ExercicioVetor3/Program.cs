using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioVetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Dado um vetor somar as 3 notas de cada aluno 
             * 2. Informar a média de cada aluno 
             * 3. Necessário a criação de 3 variáveis: uma para o Vetor, outra para Media e outra para Somar as notas 
             * 4. Usar Estrutura de Repetição*/

            double[] notas = new double[3];
            List<string> listaAlunos = new List<string>();
            List<double> listaMediaNotas = new List<double>();
            string nome;
            double soma;
            double media;

            do
            {
                Console.Write("Digite o nome do Aluno: ");
                nome = Console.ReadLine();

                //Adiciona o item à lista
                listaAlunos.Add(nome);

                soma = 0;
                for (int i = 0; i < notas.Length; i++)
                {
                    Console.WriteLine($"Digite a {i + 1}ª nota: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    soma = soma + notas[i];

                    if (i == notas.Length - 1)
                    {
                        media = soma / notas.Length;
                        //Adiciona o item à lista
                        listaMediaNotas.Add(media);
                    }       
                }
                Console.WriteLine("Quer cadastrar as notas de outro aluno? Digite sim ou [enter] para não");
            } while (!string.IsNullOrEmpty(Console.ReadLine()));

            //Exibe os alunos com a média
            for (int i = 0; i < listaAlunos.Count; i++)
            {
                Console.WriteLine("\n------------* Aluno: {0} *------------", i+1);
                Console.WriteLine($"Nome: {listaAlunos[i]}\nMédia: {listaMediaNotas[i].ToString("N2")}");
            }
            Console.ReadKey();
        }
    }
}
