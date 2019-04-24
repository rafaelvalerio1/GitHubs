using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aHeranca2
{
    class ContaEmpresa : Conta
    {
        private double limiteEmprestimo;

        public double LimiteEmprestimo
        {
            get { return limiteEmprestimo; }
            set { limiteEmprestimo = value; }
        }
        public ContaEmpresa()
        {

        }
        public ContaEmpresa(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }
        public override void Saca(double montante)
        {
            this.Saldo -= montante + 5;
        }
        public override void Deposita(double montante)
        {
            this.Saldo += montante;
        }
        public void Emprestimo(double montante)
        {
            if(montante <= LimiteEmprestimo)
            {
                Saldo += montante;
            }
        }
    }
}