using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aHeranca2
{
    class ContaPoupanca : Conta
    {
        private double taxaDeJuro;

        public ContaPoupanca()
        {

        }
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuro): base(numero, titular, saldo)
        {
            TaxaDeJuro = taxaJuro;
        }
        public double TaxaDeJuro
        {
            get { return taxaDeJuro; }
            set { taxaDeJuro = value; }
        }
        public void AtualizarSaldo()
        {

        }
        public override void Saca(double montante)
        {
            if (Saldo >= montante)
            {
                Saldo -= montante;
            }
        }

    }
}
