using Cadastro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.DAO
{
    //DAO - Data Access Objects
    public class PessoaDAO
    {
        private List<PessoaModel> repositorio;
        //Construtor - será executado quando criar uma nova DAO
        //Exemplo: PessoaDAO dao = new PessoaDAO();
        public PessoaDAO()
        {
            //Ações de Construção
            repositorio = new List<PessoaModel>();
        }
        // Ações da DAO
        //* Pesquisar
        public List<PessoaModel> Pesquisar()
        {
            return repositorio;
        }
        public List<PessoaModel> Pesquisar(string nome)
        {
            var resultado = repositorio.Where(p => p.Nome == nome);
            return resultado.ToList();
        }
        //* Consultar
        public PessoaModel Consultar(int codigo)
        {
            return null;
        }
        //* Inserir
        public bool Inserir(PessoaModel pessoa)
        {
            //Adiciona a Pessoa no repositório
            //Gambi para código automático
            //Recupera o maior valor de código existente e soma 1 utilizando o método Max com Lambda
            pessoa.Codigo = repositorio.Count == 0 ? 1 : repositorio.Max(p => p.Codigo) + 1;
            repositorio.Add(pessoa);
            //TODO - Inserir - Implementar Persistência

            return true; //Retorna verdadeiro = inseriu / falso = erro
        }
        //* Alterar
        public bool Alterar(PessoaModel pessoa)
        {
            var indice = repositorio.IndexOf(Consultar(pessoa.Codigo));
            repositorio[indice] = pessoa;
            return true; //Retorna verdadeiro = inseriu / falso = erro
        }
        //* Excluir
        public bool Excluir(PessoaModel pessoa)
        {
            return false; //Retorna verdadeiro = inseriu / falso = erro
        }
    }
}
