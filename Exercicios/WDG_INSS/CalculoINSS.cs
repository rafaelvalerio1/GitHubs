using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDG_INSS
{
    class CalculoINSS
    {
        decimal salario;
        int opcao;
        
        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public int Opcao
        {
            get { return opcao; }
            set { opcao = value; }
        }
        public int DefinirLinhasTabela(int opcao)
        {
            int linhas = 0;
            switch(opcao)
            {
                case 1:
                    linhas = 4;
                    break;
                case 2:
                    linhas = 5;
                    break;
            }
            return linhas;
        }
        public int DefinirColunasTabela(int opcao)
        {
            int colunas = 0;
            switch (opcao)
            {
                case 1:
                    colunas = 2;
                    break;
                case 2:
                    colunas = 2;
                    break;
            }
            return colunas;
        }
        public decimal[,] DefinirTabela(int opcao)
        {
            decimal[,] tabela = new decimal[DefinirLinhasTabela(Opcao), DefinirColunasTabela(Opcao)];

            //Verificar o ano para mostrar uma tabela específica cadastrada
            switch (opcao)
            {
                case 1:       
                    //Tabela de 2011
                    tabela[0, 0] = Convert.ToDecimal(1106.9);
                    tabela[0, 1] = Convert.ToDecimal(0.08);
                    tabela[1, 0] = Convert.ToDecimal(1844.43);
                    tabela[1, 1] = Convert.ToDecimal(0.09);
                    tabela[2, 0] = Convert.ToDecimal(3689.66);
                    tabela[2, 1] = Convert.ToDecimal(0.11);
                    tabela[3, 0] = Convert.ToDecimal(3689.67);
                    tabela[3, 1] = Convert.ToDecimal(405.86);
                    break;
               
                case 2:
                    //Tabela de 2012
                    tabela[0, 0] = Convert.ToDecimal(1000.00);
                    tabela[0, 1] = Convert.ToDecimal(0.07);
                    tabela[1, 0] = Convert.ToDecimal(1500.00);
                    tabela[1, 1] = Convert.ToDecimal(0.08);
                    tabela[2, 0] = Convert.ToDecimal(3000.00);
                    tabela[2, 1] = Convert.ToDecimal(0.09);
                    tabela[3, 0] = Convert.ToDecimal(4000.00);
                    tabela[3, 1] = Convert.ToDecimal(0.11);
                    tabela[4, 0] = Convert.ToDecimal(4000.01);
                    tabela[4, 1] = Convert.ToDecimal(500.00);
                    break;
            }
            return tabela;
        }
       public decimal RetornarAliquota(decimal salario, decimal[,] arr)
       {
            decimal valorInicial = Convert.ToDecimal(0.0);
            decimal aliquota = Convert.ToDecimal(0.0);
            //GetLench(0) pega a quantidade de linhas da matriz
            for (int i=0; i<arr.GetLength(0); i++)
            {
                //GetLench(1) pega a quantidade de colunas da matriz
                for (int j=0; j<arr.GetLength(1); j++)
                {
                    if(salario>=valorInicial && salario<=arr[i, j])
                    {
                        aliquota = arr[i, j + 1];
                    }
                    if(i==arr.GetLength(0)-1)
                    {
                        if(salario>=arr[i, j])
                        {
                            aliquota = arr[i, j + 1];
                        }
                    }
                    valorInicial = arr[i, j] + Convert.ToDecimal(0.01);
                    j += 1;
                }
            }
            return aliquota;
       }

        public decimal CalcularDesconto(decimal salario,  decimal[,] arr)
        {
            decimal aliquota = RetornarAliquota(salario, arr);
            decimal calcularDesconto = Convert.ToDecimal(0.0);
            if(aliquota > 1)
            {
                calcularDesconto = (salario + aliquota);
            }
            else
            {
                calcularDesconto = (salario * aliquota) + salario;
            }
            return calcularDesconto;
        }
        public void Resultado()
        {
            Console.Write($"O salário final é: {CalcularDesconto(Salario, DefinirTabela(Opcao))}");
        }
    }
}
