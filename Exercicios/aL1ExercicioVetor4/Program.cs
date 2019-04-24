using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioVetor4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Informar o Nome do Aluno
              2. Somar as 3 notas de cada aluno
              3. Informar a média de cada aluno
              4. Menção do Aluno: 
                     Aprovado > = 7 
                     Recuperação de 5.1 a 6.9 
                     Reprovado <= 5 */

            double[] notas = new double[3];
            List<string> listaAlunos = new List<string>();
            List<double> listaMediaNotas = new List<double>();
            List<string> listaMencao = new List<string>();
            string nome;
            double soma = 0;
            double media;
            string situacao;

            do
            {
                Console.Write("Digite o nome do Aluno: ");
                nome = Console.ReadLine();

                //Adiciona o item à lista
                listaAlunos.Add(nome);

                soma = 0;
                situacao = "";
                for (int i = 0; i < notas.Length; i++)
                {
                    Console.WriteLine($"Digite a {i + 1}ª nota: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());

                    soma = soma + notas[i];

                    if(notas[i]<=10)
                    {
                        if (i == notas.Length - 1)
                        {
                            if(situacao.Length == 0)
                            {
                                media = soma / notas.Length;
                                if (media <= 5)
                                {
                                    situacao = "Reprovado";
                                    //Adiciona o item à lista
                                    listaMencao.Add(situacao);
                                    listaMediaNotas.Add(media);
                                }
                                else if (media >= 5.1 && media <= 6.9)
                                {
                                    situacao = "Recuperação";
                                    listaMencao.Add(situacao);
                                    listaMediaNotas.Add(media);
                                }
                                else if (media >= 7 && media <= 10)
                                {
                                    situacao = "Aprovado";
                                    listaMencao.Add(situacao);
                                    listaMediaNotas.Add(media);
                                }
                            }
                        }
                    }
                    else
                    {
                        if(situacao.Length == 0)
                        {
                            situacao = "Média Inválida. Digite as notas de 1 a 10";
                            listaMencao.Add(situacao);
                            listaMediaNotas.Add(0);
                        }  
                    }
                }
                Console.WriteLine("Quer cadastrar as notas de outro aluno? Digite sim ou [enter] para não");
            } while (!string.IsNullOrEmpty(Console.ReadLine()));

            //Ordena a lista 
            //listaAlunos.Sort();

            //Exibe os alunos com o nome, média e menção
            for (int i = 0; i < listaAlunos.Count; i++)
            {
                Console.WriteLine("\n------------* Aluno: {0} *------------", i + 1);
                Console.WriteLine("Nome: {0}\nMédia: {1}\nMenção: {2}", listaAlunos[i], listaMediaNotas[i].ToString("N2"), listaMencao[i]);
            }
            
            Console.ReadKey();
        }
    }
}
