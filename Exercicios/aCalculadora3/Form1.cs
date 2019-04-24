using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aCalculadora3
{
    public partial class Form1 : Form
    {
        public bool cliqueOperador = false;
        public bool resultado = false;
        public string valor1;
        public string valor2;
        public string operador;

        public Form1()
        {
            InitializeComponent();
        }
        public string Concatenar()
        {
            string concatenar;
            concatenar = $"{valor1}{operador}{valor2}";
            return concatenar;
        }
        public string ExibirNaCalculadora()
        {
            btnDel.Enabled = true;
            lblResultado.Text = $"{valor1}{operador}{valor2}";
            return lblResultado.Text;
        }
        public string Deletar()
        {
            string teste = "";
            if (cliqueOperador == false)
            {
                teste = valor1.Remove(valor1.Length - 1);
                valor1 = teste;
                lblResultado.Text = $"{teste}";
            }
            else
            {
                if(valor2.Length>0)
                {
                    teste = valor2.Remove(valor2.Length - 1);
                    valor2 = teste;
                    lblResultado.Text = $"{valor1}{operador}{teste}";
                }
                else
                {
                    teste = operador.Remove(operador.Length - 1);
                    operador = teste;
                    lblResultado.Text = $"{valor1}";
                    cliqueOperador = false;
                    valor2 = null;
                    operador = null;
                }
            }
            return lblResultado.Text;
        }
        public double ConverterValor(string valor)
        {
            double conversao;
            conversao = Convert.ToDouble(valor);
            return conversao;
        }
        public double Calculo()
        {
            double resultado = 0.0;
            if(operador==" + ")
            {
                resultado = ConverterValor(valor1) + ConverterValor(valor2);
            }
            return resultado;
        }
        public void AcrescentarValor(string valor)
        {
            if (cliqueOperador == false)
                valor1 += valor;
            else
                valor2 += valor;
        }
        public void Zerar()
        {
            lblResultado.Text = "0";
            valor1 = null;
            valor2 = null;
            operador = null;
            cliqueOperador = false;
            btnDel.Enabled = false;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            AcrescentarValor("0");
            ExibirNaCalculadora();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AcrescentarValor("1");
            ExibirNaCalculadora();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            cliqueOperador = true;
            operador = " + ";
            ExibirNaCalculadora();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(cliqueOperador==true)
            {
                valor1 = $"{Calculo()}";
                valor2 = null;
                lblResultado.Text = $"{valor1}";
                resultado = true;
            }
            else
            {
                lblResultado.Text = $"{valor1}";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Zerar();
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            btnDel.Enabled = false;
            if (resultado == true)
            {
                Zerar();
                resultado = false;
            }
            if(cliqueOperador == true)
            {
                valor2 = null;
                lblResultado.Text = $"{valor1}{operador}0";
            }
            else
            {
                Zerar();
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (cliqueOperador == false)
                valor1 += ",";
            else
                valor2 += ",";
            ExibirNaCalculadora();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
            if (valor1.Length > 1)
            {
                Deletar();
            }
            else
            {
                lblResultado.Text = "0";
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
