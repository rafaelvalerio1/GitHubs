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
    public partial class FormCadastro : Form
    {
        public string msgDeSucesso;
        int? codigo;
        public FormCadastro(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
        }

        public FormCadastro(string titulo, int codigo):this(titulo)
        {
            this.codigo = codigo;
            var pessoa = BancoDeDados.Pessoas.Consultar(codigo);
            txtNome.Text = pessoa.Nome;
            txtEndereco.Text = pessoa.Endereco;
            txtCidade.Text = pessoa.Cidade;
            txtNumero.Text = pessoa.Numero.ToString();
            txtTelefone.Text = pessoa.Fone;
            cbxUf.Text = pessoa.Estado;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*Propriedades do FormCadastro:
             *FormBorderStyle = FixedSingle (não deixar o usuário redimensionar o formulário)
             * MaximizeBox = false (não deixar o usuário maximizar o formulário)
             * StartPosition = CenterParent (alinhar ao centro do formulário pai, ou seja, do formulário que irá iniciar o programa)
             */

            int inumero;
            string nome = txtNome.Text;
            string endereco = txtEndereco.Text;
            bool numero = Int32.TryParse(txtNumero.Text, out inumero);
            string telefone = txtTelefone.Text;
            string cidade = txtCidade.Text;
            string uf = cbxUf.Text;

            PessoaDAO dao = new PessoaDAO();

            if (string.IsNullOrWhiteSpace(txtNome.Text))
                MessageBox.Show("Nome precisa ser informado.");
            else if (string.IsNullOrWhiteSpace(txtEndereco.Text))
                MessageBox.Show("Endereço precisa ser informado.");
            else if (string.IsNullOrWhiteSpace(txtNumero.Text))
                MessageBox.Show("Numero precisa ser informado.");
            else if (string.IsNullOrWhiteSpace(txtTelefone.Text))
                MessageBox.Show("Telefone precisa ser informado.");
            else if (string.IsNullOrWhiteSpace(txtCidade.Text))
                MessageBox.Show("Cidade precisa ser informado.");
            else if (string.IsNullOrWhiteSpace(cbxUf.Text))
                MessageBox.Show("UF precisa ser informado.");
            else
            {
                PessoaModel pessoa = new PessoaModel();
                pessoa.Cidade = txtCidade.Text;
                pessoa.Nome = txtNome.Text;
                pessoa.Estado = cbxUf.Text;
                pessoa.Endereco = txtEndereco.Text;
                pessoa.Numero = inumero;
                pessoa.Fone = txtTelefone.Text;

                //Declara e instancio o objeto dao, do tipo PessoaDAO

                if (!codigo.HasValue)
                {
                    BancoDeDados.Pessoas.Inserir(pessoa);
                }
                else
                {
                    pessoa.Codigo = codigo.Value;
                    //Invoco o método inserir da DAO, para adicionar uma Pessoa
                    BancoDeDados.Pessoas.Alterar(pessoa); 
                }

                dao.Inserir(pessoa);

                MessageBox.Show($"Cadastro efetuado com sucesso!");
                MessageBox.Show($"Pessoa Cadastrada:\nNome: {nome}\nEndereço: {endereco}\nNumero: {inumero}\n Telefone: {telefone}\nCidade: {cidade}\nUF: {uf}\n");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
