using Cadastro.DAO;
using Cadastro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorio
{
    public partial class FormPessoa : Form
    {
        BindingSource binding;
        public FormPessoa()
        {
            InitializeComponent();
            binding = new BindingSource();
        }

        private void btnNovaPessoa_Click(object sender, EventArgs e)
        {
            /*Propriedades do FormPessoa:
             * 
             Formulário:
                *FormBorderStyle = Sizeble (o usuário pode redimensionar o formulário)
                * MaximizeBox = true (o usuário pode maximizar o formulário)
                * MinimizeBox = true (o usuário pode minimizar o formulário)
                * StartPosition = CenterScreen (o formulário será colocado no centro ao ser iniciado)
                * WindowState = Maximized (o formulário iniciará maximizado ao máximo)
   
             Botão Nova Pessoa:
                * Anchor = Top, Right (o botão será mantido no mesmo local, mesmo quando o formulário for redimensionado)    
             */
            FormCadastro cadastro = new FormCadastro("Cadastro de Pessoa");
            cadastro.ShowDialog();
            AtualizarGrid();
            MessageBox.Show(cadastro.msgDeSucesso, "Sucesso");
        }

        private void FormPessoa_FormClosing(object sender, FormClosingEventArgs e)
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
        private void AtualizarGrid(object data = null)
        {
            binding.DataSource = data ?? BancoDeDados.Pessoas.Pesquisar();
            binding.ResetBindings(true);
            dgvPessoas.DataSource = binding;
        }

        private void FormPessoa_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvPessoas.DataSource = BancoDeDados.Pessoas.Pesquisar(txtNome.Text);
        }

        private void dgvPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var pessoa = (PessoaModel)dgvPessoas.Rows[e.RowIndex].DataBoundItem;
            FormCadastro cadastro = new FormCadastro("Minha Tela de Alteração de Pessoa", pessoa.Codigo);
            cadastro.ShowDialog();
            AtualizarGrid();
        }

        private void dgvPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
