using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aHeranca2
{
    class Conta
    {
        private int numero;
        private string titular;
        private double saldo;

        public Conta()
        {
            
        }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public virtual void Saca(double montante)
        {
            if (Saldo >= montante)
            {
                Saldo -= montante + 5;
            }
        }
        public virtual void Deposita(double montante)
        {
            this.saldo += montante;
        }
    }
}
