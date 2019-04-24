using System;
using System.Collections.Generic;
using System.Text;

namespace Relatorio
{
    public class PessoaRelatorio
    {
        //propfull + tab + tab (Cria um atributo com sua propriedade)
        #region Atributos
        private string nome;
        private string endereco;
        private int numero;
        private string fone;
        private string cidade;
        private string estado;
        #endregion

        #region Construtor 
        public PessoaRelatorio(/*string nome, string endereco, int numero, string fone, string cidade, string estado*/)
        {
            //this.nome = nome;
            //this.endereco = endereco;
            //this.numero = numero;
            //this.fone = fone;
            //this.cidade = cidade;
            //this.estado = estado;
        }
        #endregion

        #region Propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Fone
        {
            get { return fone; }
            set { fone = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion
    }
}
