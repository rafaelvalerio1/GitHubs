using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio6
{
    class Carro
    {
        float valorCarro;
        int anoCarro;

        public float ValorCarro
        {
            get { return valorCarro; }
            set { valorCarro = value; }
        }
        public int AnoCarro
        {
            get { return anoCarro; }
            set { anoCarro = value; }
        }

        public float RetornarDesconto(int ano)
        {
            float desconto = 0.0f;

            if(ano<=2015)
            {
                desconto = 0.12f;
            }
            else if(ano>2015)
            {
                desconto = 0.07f;
            }
            return desconto;
        }
        public int NumCarrosAte2015(List<int> lista1)
        {
            int contador = 0;
            for(int i = 0; i<lista1.Count; i++)
            {
                if(lista1[i]<=2015)
                {
                    contador++;
                }
            }
            return contador;
        }
        public int NumCarrosTotalGeral(List<int> lista1)
        {
            int contador = 0;
            for (int i = 0; i < lista1.Count; i++)
            {
                contador++;
            }
            return contador;
        }
        public float CalcularDescontoCarro(List<float> lista1, List<int> lista2, int indice)
        {
            int ano = 0;
            ano = lista2[indice];

            float desconto = lista1[indice] - (lista1[indice] * RetornarDesconto(ano));

            return desconto;
        }
    }
}
