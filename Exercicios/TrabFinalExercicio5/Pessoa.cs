using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio5
{
    class Pessoa
    {
        char[] sexo = new char[5];
        string[] nome = new string[5];

        public char[] Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string[] Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string InformarSexo(char[] sexo, int numIndice)
        {
            string resultado = "";

            switch (sexo[numIndice])
            {
                case 'M':
                case 'm':
                    resultado = "Masculino";
                    break;
                case 'F':
                case 'f':
                    resultado = "Feminino";
                    break;
                default:
                    resultado = "Dados Inválidos";
                    break;
            }

            return resultado;
        }
        public int RetornarTotalHomens(char[] sexo)
        {
            int total = 0;

            for(int i=0; i<sexo.Length; i++)
            {
                switch (sexo[i])
                {
                    case 'M':
                    case 'm':
                        total++;
                        break;
                }
            }
            return total;
        }
        public int RetornarTotalMulheres(char[] sexo)
        {
            int total = 0;

            for (int i = 0; i < sexo.Length; i++)
            {
                switch (sexo[i])
                {
                    case 'F':
                    case 'f':
                        total++;
                        break;
                }
            }
            return total;
        }
    }
}
