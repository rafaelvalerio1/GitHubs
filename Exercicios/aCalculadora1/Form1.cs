using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aCalculadora1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(txtValor1.Text);
            float valor2 = float.Parse(txtValor2.Text);
            float soma = valor1 + valor2;

            lblResultado.Text = $"{soma}";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(txtValor1.Text);
            float valor2 = float.Parse(txtValor2.Text);
            float subtracao = valor1 - valor2;

            lblResultado.Text = $"{subtracao}";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(txtValor1.Text);
            float valor2 = float.Parse(txtValor2.Text);
            float multiplicacao = valor1 * valor2;

            lblResultado.Text = $"{multiplicacao}";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(txtValor1.Text);
            float valor2 = float.Parse(txtValor2.Text);
            float divisao = valor1 / valor2;
            lblResultado.Text = $"{divisao}";
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            if(txtValor2.TextLength > 0)
            {
                txtValor2.Text = "";
            }
            else
            {
                txtValor1.Text = "";
            }
            
            lblResultado.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            lblResultado.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
