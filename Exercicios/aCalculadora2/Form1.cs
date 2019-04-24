using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aCalculadora2
{
    public partial class Form1 : Form
    {
        public bool primeiro = true;
        public string valor1;
        public string valor2;
        public string simboloConta;
        public bool simbolo = false;
        public Form1()
        {
            InitializeComponent();
        }
        public double ConverterValor1()
        {
            double conversao;
            conversao = Convert.ToDouble(valor1);
            return conversao;
        }
        public double ConverterValor2()
        {
            double conversao;
            conversao = Convert.ToDouble(valor2);
            return conversao;
        }
        public double Calcular()
        {
            double resultado = 0.0;
            if(simboloConta == "+")
                resultado = ConverterValor1() + ConverterValor2();
            else if(simboloConta == "-")
                resultado = ConverterValor1() - ConverterValor2();
            else if (simboloConta == "x")
                resultado = ConverterValor1() * ConverterValor2();
            else if (simboloConta == "÷")
                resultado = ConverterValor1() / ConverterValor2();
            return resultado;
        }
        public string ConcatenarValores(string valor)
        {
            if(primeiro==true)
            {
                lblResultado.Text = "";
                primeiro = false;
            }
            lblResultado.Text += $"{valor}";
            return lblResultado.Text;
        }
        public void Zerar()
        {
            lblResultado.Text = "0";
            valor1 = null;
            valor2 = null;
            simboloConta = null;
            simbolo = false;
            primeiro = true;
            btnVirgula.Enabled = true;
        }
        public void DesabilitarOperadores()
        {
            btnAdicao.Enabled = false;
            btnSubtracao.Enabled = false;
            btnMultiplicacao.Enabled = false;
            btnDivisao.Enabled = false;
        }
        public void HabilitarOperadores()
        {
            btnAdicao.Enabled = true;
            btnSubtracao.Enabled = true;
            btnMultiplicacao.Enabled = true;
            btnDivisao.Enabled = true;
        }
        //CONTROLES ADICIONAIS PARA O USUÁRIO
        private void btnC_Click(object sender, EventArgs e)
        {
            Zerar();
            HabilitarOperadores();
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            ConcatenarValores(",");
            if (simbolo == false)
                valor1 += ",";
            else
                valor2 += ",";
            btnVirgula.Enabled = false;
        }

        //BOTÕES DOS NÚMEROS [0 a 9]
        private void btn0_Click(object sender, EventArgs e)
        {
            ConcatenarValores("0");
            if (simbolo == false)
                valor1 += "0";
            else
                valor2 += "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            ConcatenarValores("1");
            if (simbolo == false)
                valor1 += "1";
            else
                valor2 += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ConcatenarValores("2");
            if (simbolo == false)
                valor1 += "2";
            else
                valor2 += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            ConcatenarValores("3");
            if (simbolo == false)
                valor1 += "3";
            else
                valor2 += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ConcatenarValores("4");
            if (simbolo == false)
                valor1 += "4";
            else
                valor2 += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ConcatenarValores("5");
            if (simbolo == false)
                valor1 += "5";
            else
                valor2 += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ConcatenarValores("6");
            if (simbolo == false)
                valor1 += "6";
            else
                valor2 += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ConcatenarValores("7");
            if (simbolo == false)
                valor1 += "7";
            else
                valor2 += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ConcatenarValores("8");
            if (simbolo == false)
                valor1 += "8";
            else
                valor2 += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ConcatenarValores("9");
            if (simbolo == false)
                valor1 += "9";
            else
                valor2 += "9";
        }

        //CÁLCULOS
        private void btnAdicao_Click(object sender, EventArgs e)
        {
            ConcatenarValores(" + ");
            simboloConta = "+";
            simbolo = true;
            DesabilitarOperadores();
            btnVirgula.Enabled = true;
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            ConcatenarValores(" - ");
            simboloConta = "-";
            simbolo = true;
            DesabilitarOperadores();
            btnVirgula.Enabled = true;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            ConcatenarValores(" x ");
            simboloConta = "x";
            simbolo = true;
            DesabilitarOperadores();
            btnVirgula.Enabled = true;
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {
            ConcatenarValores(" ÷ ");
            simboloConta = "÷";
            simbolo = true;
            DesabilitarOperadores();
            btnVirgula.Enabled = true;
        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            valor1 = $"{Calcular()}";
            lblResultado.Text = valor1;
            valor2 = null;
            simboloConta = null;
            simbolo = false;
            HabilitarOperadores();
            btnVirgula.Enabled = true;
        } 
    }
}
