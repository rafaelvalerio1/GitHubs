using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoBanco
{
    public partial class frmSaque : Form
    {
        private decimal saldo;
        private decimal valor;
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public frmSaque()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            txtValor.Text = Valor.ToString();
            if (!string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Saque efetuado com sucesso");
                this.Close();
            }  
            else
                MessageBox.Show("Insira um valor para saque");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmSaque_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmSaque_Load(object sender, EventArgs e)
        {
            txtValor.Text = $"0,00";
            txtSaldo1.Text = saldo.ToString();
            txtSaldo1.Enabled = false;  
        }
    }
}
