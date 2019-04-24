using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalExercicio2
{
    class Vendedor
    {
        string nome;
        double salario;
        int valorVendas;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public int ValorVendas
        {
            get { return valorVendas; }
            set { valorVendas = value; }
        }

        public double RetornarComissao(double salario, double porcentagemComissao)
        {
            double salarioFinal = (salario * porcentagemComissao) + salario;
            return salarioFinal;
        }
    }
}
