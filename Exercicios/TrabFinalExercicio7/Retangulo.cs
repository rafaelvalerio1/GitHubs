using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio7
{
    class Retangulo
    {
        float largura, altura;

        public float Largura
        {
            get { return largura; }
            set { largura = value; }
        }
        public float Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public float CalcularArea(float largura, float altura)
        {
            float area = largura * altura;
            return area;
        }
    }
}
