using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrabFinalwExercicio14
{
    class Loteria
    {
        private int numero;
        private int qtdNumeros;
        private string nome;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int QtdNumeros
        {
            get { return qtdNumeros; }
            set { qtdNumeros = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<int> GerarJogoAleatorio(int repeticao)
        {
            int qtd = 10;
            Random rd = new Random();
            List<int> numeros = new List<int>();
            int number = 0;
            for (int i = 0; i < repeticao; i++)
            {
                number = rd.Next(0, qtd + 1);
                while (numeros.Contains(number))
                {
                    //Quando ficar em loop infinito eu vou quebrar o laço                    
                    if (numeros.Count >= qtd)   
                        break;
                    else
                        number = rd.Next(0, qtd + 1);
                }
                numeros.Add(number);
                numeros.Sort();
            }
            return numeros;
        }
        public int ContarAcertos(int indiceInicial, int indiceFinal,  List<int> listaNumJogados, List<int>listaJogo)
        {
            int contador = 0;
            for (int l = indiceInicial; l < indiceFinal; l++)
            {
                for (int n = 0; n < 3; n++)
                {
                    if (listaNumJogados[l] == listaJogo[n])
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }
        public string VerificarRequisito(int numInicial, int numFinal, int numTeste, List<int> listaNumJogados)
        {
            string resultado = "";
            for (int i = numInicial; i < numFinal; i++)
            {
                if (listaNumJogados[numTeste] == listaNumJogados[i])
                {
                    resultado = "VOCÊ ESTÁ DESCLASSIFICADO...Digitou números iguais";
                }
                else if(listaNumJogados[i-1] > 10)
                {
                    resultado = "VOCÊ ESTÁ DESCLASSIFICADO...Digitou números maiores que 10";
                }
            }
            return resultado;
        }
    }
}
