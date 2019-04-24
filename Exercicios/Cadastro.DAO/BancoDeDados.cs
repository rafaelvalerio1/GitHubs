using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.DAO
{
    public static class BancoDeDados
    {
        private static PessoaDAO pessoaDAO;

        public static PessoaDAO Pessoas
        {
            get
            {//Controla a inicialização da DAO
                pessoaDAO = pessoaDAO ?? new PessoaDAO();
                return pessoaDAO;
            }
            set { pessoaDAO = value; }
        }
    }
}
