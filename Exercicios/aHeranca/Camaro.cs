using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aHeranca
{
    class Camaro : Veiculo
    {
        public Camaro(string marca, string modelo, int qtdPortas, string potencia, string combustivel, bool cambioAutomatico, int aroRodas, string versao) : base(marca, modelo, qtdPortas, potencia, combustivel, cambioAutomatico, aroRodas, versao)
        {

        }
    }
}
