using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciei a classe PecaLego
            PecaLego pl = new PecaLego();
            pl.cor = "Azul"; 
            pl.altura = 0.7f;
            pl.numPinosX = 8;
            pl.numPinosY = 2;

            PecaLego pl2 = new PecaLego();
            pl2.cor = "Vermelha";
            pl2.altura = 0.9f;
            pl2.numPinosX = 10;
            pl2.numPinosY = 20;

            //Chamar o método Mover()
            pl.Mover(1, 2, 3);

            Console.WriteLine($"Minha peça lego 1 possui a cor {pl.cor}");
            Console.WriteLine($"Minha peça lego 2 possui a cor {pl2.cor}");
            Console.ReadKey();
        }
    }

    class PecaLego
    {
        //Atributos
        public string cor;
        public float altura;
        public int numPinosX;
        public int numPinosY;

        public void Encaixar()
        {
            //Ações que o método irá executar
        }
        public int Mover(int posX, int posY, int posZ)
        {
            int i = 10;
            return i;
        }
    }
}
