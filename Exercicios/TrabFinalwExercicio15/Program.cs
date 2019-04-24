using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalwExercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz matriz1 = new Matriz();

                //Lendo os Dados da Matriz A
                Console.WriteLine("\n========* MATRIZ A *========");
                matriz1.LendoDados(matriz1.MatrizA);

                //Lendo os Dados da Matriz B
                Console.WriteLine("\n========* MATRIZ B *========");
                matriz1.LendoDados(matriz1.MatrizB);

                //Exibindo os Dados da Matriz A
                Console.WriteLine("\n========* MATRIZ A *========");
                matriz1.ExibindoDados(matriz1.MatrizA);

                //Exibindo os Dados da Matriz B
                Console.WriteLine("\n\n\n========* MATRIZ B *========");
                matriz1.ExibindoDados(matriz1.MatrizB);

                //Exibindo os Dados da Matriz C
                Console.WriteLine("\n\n\n========* MATRIZ C *========");
                matriz1.ExibindoDados(matriz1.MultiplicacaoMatriz(matriz1.MatrizA, matriz1.MatrizB));

            Console.ReadKey();
        }
    }
}
