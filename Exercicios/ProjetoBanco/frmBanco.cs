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
    public partial class frmBanco : Form
    {
       
        frmSaque saque = new frmSaque();

        public frmBanco()
        {
            InitializeComponent();
        }
        public decimal CalcularSaldo()
        {
            decimal resultado;
            resultado = saque.Saldo - saque.Valor;
            return resultado;
        }
        private void btnSaque_Click(object sender, EventArgs e)
        {
            saque.Saldo = Decimal.Parse(txtSaldo.Text);
            saque.ShowDialog();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            frmDeposito deposito = new frmDeposito();
            deposito.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmBanco_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmBanco_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            DriveInfo[] alldrivers = DriveInfo.GetDrives();
            //item.DriveType.ToString() == "Removable"
            foreach (DriveInfo item in alldrivers)
            {
                lista.Add($"Nome: {item}");
                lista.Add($"Volume: {item.DriveType.ToString()}");

                if (item.IsReady == true && item.DriveType.ToString() == "Removable")
                {
                    string conta = item.TotalSize.ToString();
                    string remover = conta.Remove(conta.Length - 5);
                    panelResultado.Visible = false;
                    lblMensagem.Visible = false;
                    txtSaldo.Text = $"{item.TotalSize}";
                    txtNome.Text = $"{item.VolumeLabel}";
                    txtConta.Text = $"{remover}";
                    txtNome.Enabled = false;
                    txtConta.Enabled = false;
                    txtSaldo.Enabled = false;
                }
                else
                {
                    lblMensagem.Text = "Insira o Cartão";
                }
            }
        }
    }
}
