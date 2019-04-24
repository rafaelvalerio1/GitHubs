using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aSemHeranca
{
    class Mustang
    {
        private string marca;
        private string modelo;
        private int qtdPortas;
        private string potencia;
        private string combustivel;
        private bool cambioAutomatico;
        private int aroRodas;
        private string versao;

        public Mustang(string marca, string modelo, int qtdPortas, string potencia, string combustivel, bool cambioAutomatico, int aroRodas, string versao)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.qtdPortas = qtdPortas;
            this.potencia = potencia;
            this.combustivel = combustivel;
            this.cambioAutomatico = cambioAutomatico;
            this.aroRodas = aroRodas;
            this.versao = versao;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int QtdPortas
        {
            get { return qtdPortas; }
            set { qtdPortas = value; }
        }
        public string Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }
        public string Combustivel
        {
            get { return combustivel; }
            set { combustivel = value; }
        }
        public bool CambioAutomatico
        {
            get { return cambioAutomatico; }
            set { cambioAutomatico = value; }
        }
        public int AroRodas
        {
            get { return aroRodas; }
            set { aroRodas = value; }
        }
        public string Versao
        {
            get { return versao; }
            set { versao = value; }
        }

        public string Mover()
        {
            return null;
        }
        public string Frear()
        {
            return null;
        }
        public string Virar()
        {
            return null;
        }
    }
}
