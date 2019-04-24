using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aWindowsForms1
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //ctrl + kc = comentar || ctrl + ku = descomentar
            //MessageBox.Show("Olá Turma 43", "Bem-Vindos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            txtNome.Text = "João da Silva";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //ctrl + kc = comentar || ctrl + ku = descomentar
            //MessageBox.Show("Você deseja cancelar?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            txtNome.Text = "";
        }
    }
}
