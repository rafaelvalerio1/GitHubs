using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio3
{
    class Aluno
    {
        string nome;
        double[] notas = new double[3];

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        public double CalcularMedia(double[] notas)
        {
            double soma = 0;
            double media;
            for(int i=0; i<notas.Length; i++)
            {
                soma += notas[i];
            }
            media = soma / notas.Length;
            return media;
        }

    }
}
