using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aL1ExercicioVetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Dado um Vetor informe a saída do Fabricante e o
                Modelo correto do Carro do Fabricante, além da
                posição correta de cada dado:
                -------------------------------------
                POSIÇÃO      FABRICANTE     MODELO
                   2         VOLKSWAGEN     Palio
                   4         FIAT           Golf
                   1         CHEVROLET      KA
                   3         FORD           Corsa
                --------------------------------------
            */

            int tamanhoVetor = 4;
            string[] fabricante = new string[tamanhoVetor];
            string[] modelo = new string[tamanhoVetor];

            fabricante[0] = "CHEVROLET";
            fabricante[1] = "VOLKSWAGEN";
            fabricante[2] = "FORD";
            fabricante[3] = "FIAT";

            modelo[0] = "Ka";
            modelo[1] = "Palio";
            modelo[2] = "Corsa";
            modelo[3] = "Golf";

            Console.WriteLine($"1ª posição: Fabricante {fabricante[0]} | Modelo {modelo[2]}");
            Console.WriteLine($"2ª posição: Fabricante {fabricante[1]} | Modelo {modelo[3]}");
            Console.WriteLine($"3ª posição: Fabricante {fabricante[2]} | Modelo {modelo[0]}");
            Console.WriteLine($"4ª posição: Fabricante {fabricante[3]} | Modelo {modelo[1]}");
           
            Console.ReadKey();
        }
    }
}
