using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioVetor5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Jogo da tabuada 
             * 2. Respondeu corretamente ganha 1 ponto 
             * 3. Fazer apenas 3 questões conforme saída de tela:*/

            int tamanhoVetor = 3;
            int[] resposta = new int[tamanhoVetor];
            string[] conta = new string[tamanhoVetor];
            conta[0] = "2 x 8";
            conta[1] = "3 x 9";
            conta[2] = "7 x 6";

            int[] resultado = new int[tamanhoVetor];
            resultado[0] = 2 * 8;
            resultado[1] = 3 * 9;
            resultado[2] = 7 * 6;

            int cont = 0;

            for (int i = 0; i<resposta.Length; i++)
            {
                Console.Write($"\nQuanto é {conta[i]}? --> Resposta: ");
                resposta[i] = Convert.ToInt32(Console.ReadLine());

                if(resposta[i] == resultado[i])
                {
                    cont++;
                    Console.WriteLine("Certa Resposta!");
                }
                else
                {
                    Console.WriteLine($"Resposta errada... A resposta é {resultado[i]}");
                }
            }
            Console.WriteLine($"\nVocê fez {cont} pontos");
            Console.ReadKey();
        }
    }
}
