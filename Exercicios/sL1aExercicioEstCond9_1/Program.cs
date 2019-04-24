using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond9_1
{
    /*9) Crie um Programa em C# que leia dois valores (considere que não serão lidos valores iguais) e escrevê-los em ordem crescente. */
    public class ValoresOrdenados
    {
        int[] valor = new int[4];

        public int[] Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public void OrdemCrescente()
        {
            int aux;
            //Lógica para deixar valores em ordem crescente no vetor
            for (int i = 0; i < Valor.Length; i++)
            {
                for (int j = i + 1; j < Valor.Length; j++)
                {
                    if (Valor[i] > Valor[j])
                    {
                        aux = Valor[i];
                        Valor[i] = Valor[j];
                        Valor[j] = aux;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ValoresOrdenados valor1 = new ValoresOrdenados();

            //Lendo os valores
            for (int i = 0; i < valor1.Valor.Length; i++)
            {
                Console.Write("Digite o {0}° valor: ", i + 1);
                valor1.Valor[i] = Convert.ToInt32(Console.ReadLine());
            }

            valor1.OrdemCrescente();

            //Exibindo os valores
            for (int i = 0; i < valor1.Valor.Length; i++)
            {
                string separador = " - ";
                if (i < valor1.Valor.Length - 1)
                {
                    Console.Write("{0}{1}", valor1.Valor[i], separador);
                }
                else if (i < valor1.Valor.Length)
                {
                    Console.Write(valor1.Valor[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
