using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1aExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Receba 3 notas, mostre a media entre elas, mostre se o aluno está aprovado ou reprovado, considerando que se o aluno tiver a media maior ou igual a 7 ele esteja aprovado*/

            double[] notas = new double[3];
            double soma;
            double media;
            string aluno;
            int valorVariavel1 = 0;
            int valorVariavel2 = notas.Length;
            string situacao;
            bool exibirNotas = true;
            List<bool> listaExibicao = new List<bool>();
            List<string> listaAlunos = new List<string>();
            List<double> listaNotas = new List<double>();
            List<double> listaMedias = new List<double>();
            List<string> listaVerificacao = new List<string>();

            do
            {
                Console.Write("Digite o nome: ");
                aluno = Console.ReadLine();
                listaAlunos.Add(aluno);

                soma = 0;
                media = 0.0;
                situacao = "";
                for(int i = 0; i < notas.Length; i++)
                {
                    Console.Write($"Digite a {i + 1} nota: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    listaNotas.Add(notas[i]);

                    soma = soma + notas[i];
                    
                    if (notas[i]<=10)
                    {
                        if (situacao.Length == 0)
                        {
                            if (i == notas.Length - 1)
                            {
                                media = soma / notas.Length;
                                listaMedias.Add(media);
                                exibirNotas = true;
                                if (media < 7)
                                {
                                    situacao = "Reprovado";
                                    listaVerificacao.Add(situacao);
                                    listaExibicao.Add(exibirNotas);
                                }
                                else
                                {
                                    
                                    situacao = "Aprovado";
                                    listaVerificacao.Add(situacao);
                                    listaExibicao.Add(exibirNotas);
                                }
                            }
                        }
                    }
                    else
                    {
                        if(situacao.Length==0)
                        {
                            exibirNotas = false;
                            situacao = "Nota Inválida. Digite notas de 0 a 10";
                            listaMedias.Add(0.0);
                            listaVerificacao.Add(situacao);
                            listaExibicao.Add(exibirNotas);
                        }
                    }
                }

                Console.WriteLine("Deseja adicionar mais alunos? Digite sim ou [enter] para não");
            } while (!string.IsNullOrEmpty(Console.ReadLine()));

            for(int i = 0; i<listaAlunos.Count;i++)
            {
                Console.WriteLine($"\nAluno {i+1}: {listaAlunos[i]}");

                for (int j = valorVariavel1; j < valorVariavel2; j++)
                {
                    if(listaExibicao[i] == true)
                    {
                        Console.WriteLine($"Nota {j + 1}: {listaNotas[j]}");
                    }
                }            
                Console.WriteLine($"Média: {listaMedias[i].ToString("N1")}");
                Console.WriteLine($"Situação: {listaVerificacao[i]}");
                valorVariavel1 += 3;
                valorVariavel2 += 3;
            }
            Console.ReadKey();
        }
    }
}
