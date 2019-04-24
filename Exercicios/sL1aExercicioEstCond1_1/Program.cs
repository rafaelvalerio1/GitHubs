using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond1_1
{
    /*1) Faça um Programa em C# que leia a idade de uma pessoa expressa em anos,
      meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
      Considerar ano com 365 dias e mês com 30 dias.*/
    public class ConverterIdade
    {
        int dia, mes, ano;

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public int CalcularQtdAnosBissextos(int anoMenor,  int anoMaior)
        {
            int anoBissexto = 0;
            for (int i = anoMenor; i <= anoMaior; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                {
                    anoBissexto++;
                }
            }
            return anoBissexto;
        }
        public int CalcularAnoAnterior(int anoAtual)
        {
            int anoAnterior = anoAtual - 1;
            return anoAnterior;
        }
        public bool VerificarAnoBissexto(int ano)
        {
            bool bissexto;
            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            {
                bissexto = true;
            }
            else
            {
                bissexto = false;
            }
            return bissexto;
        }
        public int DefinirQtdDiasAno(int ano)
        {
            int diasAno;
            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            {
                diasAno = 366;
            }
            else
            {
                diasAno = 365;
            }
            return diasAno;
        }
        public int DefinirQtdDiasMes(int numMes, bool bissexto)
        {
            int diasMes = 0;
            switch (numMes)
            {
                case 2:
                    if (bissexto == true)
                    {
                        diasMes = 29;
                    }
                    else
                    {
                        diasMes = 28;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    diasMes = 30;
                    break;
                default:
                    diasMes = 31;
                    break;
            }
            return diasMes;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConverterIdade idade1 = new ConverterIdade();

            int idadeAnos, idadeDias;

            Console.Write("\n--------CONVERTER IDADE PARA DIAS--------\n");
            Console.Write("Digite o dia do seu nascimento: ");
            idade1.Dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o mes do seu nascimento: ");
            idade1.Mes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o ano do seu nascimento: ");
            idade1.Ano = Convert.ToInt32(Console.ReadLine());

            DateTime dataAtual = DateTime.Now;
            DateTime dataNascimento = new DateTime(idade1.Ano, idade1.Mes, idade1.Dia);
            DateTime diaNascAnoAtual = new DateTime(dataAtual.Year, idade1.Mes, idade1.Dia);
            DateTime anoPassado = new DateTime(idade1.CalcularAnoAnterior(dataAtual.Year), idade1.Mes, idade1.Dia);

            idadeAnos = dataAtual.Year - dataNascimento.Year;
           
            //Lógica para verificar a idade
            if (dataNascimento.Day <= idade1.DefinirQtdDiasMes(dataNascimento.Year, idade1.VerificarAnoBissexto(dataNascimento.Year)))
            {
                if (dataNascimento.Month <= 12)
                {
                    if (dataNascimento.Year <= dataAtual.Year)
                    {
                        if (dataNascimento.Year < dataAtual.Year)
                        {
                            if (dataNascimento.Month == dataAtual.Month)
                            {
                                if (dataNascimento.Day < dataAtual.Day)
                                {
                                    if (idade1.VerificarAnoBissexto(dataNascimento.Year) == true)
                                    {
                                        idadeDias = (idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) - 1) * 366 + (idadeAnos - (idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) - 1)) * 365 + dataAtual.DayOfYear - diaNascAnoAtual.DayOfYear;
                                    }
                                    else
                                    {
                                        idadeDias = idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) * 366 + (idadeAnos - idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year)) * 365 + dataAtual.DayOfYear - diaNascAnoAtual.DayOfYear;
                                    }

                                    Console.WriteLine("Você possui {0} dias de idade", idadeDias);
                                }
                                else if (dataNascimento.Day > dataAtual.Day)
                                {
                                    idadeAnos--;
                                    if (idade1.VerificarAnoBissexto(dataNascimento.Year) == true)
                                    {
                                        idadeDias = (idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) - 1) * 366 + (idadeAnos - (idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) - 1)) * 365 + (idade1.DefinirQtdDiasAno(anoPassado.Year) - anoPassado.DayOfYear) + dataAtual.DayOfYear;
                                    }
                                    else
                                    {
                                        idadeDias = idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) * 366 + (idadeAnos - idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year)) * 365 + (idade1.DefinirQtdDiasAno(anoPassado.Year) - anoPassado.DayOfYear) + dataAtual.DayOfYear;
                                    }

                                    Console.WriteLine("Você possui {0} dias de idade", idadeDias);
                                }
                                else
                                {
                                    if (idade1.VerificarAnoBissexto(dataNascimento.Year) == true)
                                    {
                                        idadeDias = (idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) - 1) * 366 + (idadeAnos - (idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) - 1)) * 365;
                                    }
                                    else
                                    {
                                        idadeDias = idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) * 366 + (idadeAnos - idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year)) * 365;
                                    }
                                    Console.WriteLine("Você possui {0} dias de idade", idadeDias);
                                }
                            }
                            else if (dataNascimento.Month > dataAtual.Month)
                            {
                                idadeAnos--;
                                if (idade1.VerificarAnoBissexto(dataNascimento.Year) == true)
                                {
                                    idadeDias = (idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) - 1) * 366 + (idadeAnos - (idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) - 1)) * 365 + (idade1.DefinirQtdDiasAno(anoPassado.Year) - anoPassado.DayOfYear) + dataAtual.DayOfYear;
                                }
                                else
                                {
                                    idadeDias = idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) * 366 + (idadeAnos - idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year)) * 365 + (idade1.DefinirQtdDiasAno(anoPassado.Year) - anoPassado.DayOfYear) + dataAtual.DayOfYear;
                                }

                                Console.WriteLine("Você possui {0} dias de idade", idadeDias);
                            }
                            else
                            {
                                idadeDias = idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year) * 366 + (idadeAnos - idade1.CalcularQtdAnosBissextos(dataNascimento.Year, dataAtual.Year)) * 365 + dataAtual.DayOfYear - diaNascAnoAtual.DayOfYear;
                                Console.WriteLine("Você possui {0} dias de idade", idadeDias);
                            }
                        }
                        //Calculando se o ano de nascimento é igual ao ano atual
                        else if (dataNascimento.Year == dataAtual.Year)
                        {
                            if (dataNascimento.Month < dataAtual.Month)
                            {
                                idadeDias = dataAtual.DayOfYear - dataNascimento.DayOfYear;
                                Console.WriteLine("Você possui {0} dias de idade", idadeDias);
                            }
                            else if (dataNascimento.Month == dataAtual.Month)
                            {
                                idadeDias = dataAtual.DayOfYear - dataNascimento.DayOfYear;
                                Console.WriteLine("Você possui {0} dias de idade", idadeDias);
                            }
                            else
                            {
                                Console.WriteLine("Mês superior ao mês deste ano");
                            }
                        }
                        //Se o ano de nascimento for maior que o ano atual
                        else
                        {
                            Console.WriteLine("Não existe ano de nascimento maior que o ano atual");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ano Inválido. Este ano ainda não chegou");
                    }
                }
                else
                {
                    Console.WriteLine("Mês Inválido. Digite de 1 a 12 para o mês");
                }
            }
            else
            {
                Console.WriteLine("Dia Inválido. Digite de 1 a 31 para o dia");
            }
            Console.ReadKey();
        }
    }
}
