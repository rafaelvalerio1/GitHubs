using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1aExercicioEstCond1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1) Faça um Programa em C# que leia a idade de uma pessoa expressa em anos,
            meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
            Considerar ano com 365 dias e mês com 30 dias.*/

            int dia, mes, ano, idadeAnos, idadeDias, anoAnterior;

            Console.Write("\n--------CONVERTER IDADE PARA DIAS--------\n");
            Console.Write("Digite o dia do seu nascimento: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o mes do seu nascimento: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o ano do seu nascimento: ");
            ano = Convert.ToInt32(Console.ReadLine());

            DateTime dataAtual = DateTime.Now;
            DateTime dataNascimento = new DateTime(ano, mes, dia);
            DateTime diaNascAnoAtual = new DateTime(dataAtual.Year, mes, dia);

            anoAnterior = dataAtual.Year - 1;
            DateTime anoPassado = new DateTime(anoAnterior, mes, dia);

            //Verificando se o ano anterior ao ano atual é bissexto e definindo a quantidade de dias desse ano anterior
            int diasAno = 0;
            if ((anoPassado.Year % 4 == 0 && anoPassado.Year % 100 != 0) || anoPassado.Year % 400 == 0)
            {
                diasAno = 366;
            }
            else
            {
                diasAno = 365;
            }

            //Verificando se o ano de nascimento é bissexto e depois armazenando na variável booleana
            bool bissexto;
            if ((dataNascimento.Year % 4 == 0 && dataNascimento.Year % 100 != 0) || dataNascimento.Year % 400 == 0)
            {
                bissexto = true;
            }
            else
            {
                bissexto = false;
            }

            //Verificando a quantidade de dias que um determinado mês possui. OBS: Se o ano for bissexto o mês de fevereiro terá 29 dias
            int diasMes = 0;
            switch (dataNascimento.Month)
            {
                case 2:
                    if(bissexto==true)
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

            //Contar a quantidade de anos bissextos do nascimento até hoje
            int anoBissexto = 0;
            for (int i = dataNascimento.Year; i <= dataAtual.Year; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                {
                    anoBissexto++;
                }
            }

            idadeAnos = dataAtual.Year - dataNascimento.Year;
            //Lógica para verificar a idade
            if (dataNascimento.Day <= diasMes)
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
                                    if(bissexto==true)
                                    {
                                        idadeDias = (anoBissexto - 1) * 366 + ((idadeAnos - (anoBissexto - 1)) * 365) + dataAtual.DayOfYear - diaNascAnoAtual.DayOfYear;
                                    }
                                    else
                                    {
                                        idadeDias = anoBissexto * 366 + ((idadeAnos - anoBissexto) * 365) + dataAtual.DayOfYear - diaNascAnoAtual.DayOfYear;
                                    }
                                   
                                    Console.WriteLine("Você possui {0} dias de idade", idadeDias);
                                }
                                else if (dataNascimento.Day > dataAtual.Day)
                                {
                                    idadeAnos--;
                                    if(bissexto==true)
                                    {
                                        idadeDias = (anoBissexto - 1) * 366 + ((idadeAnos -                         (anoBissexto - 1)) * 365) + (diasAno - anoPassado.DayOfYear) +              dataAtual.DayOfYear;
                                    }
                                    else
                                    {
                                        idadeDias = anoBissexto * 366 + ((idadeAnos - anoBissexto) *                365) + (diasAno - anoPassado.DayOfYear) + dataAtual.DayOfYear;
                                    }
                                    
                                    Console.WriteLine("Você possui {0} dias de idade", idadeDias);
                                }
                                else
                                {
                                    if(bissexto==true)
                                    {
                                        idadeDias = (anoBissexto - 1) * 366 + ((idadeAnos - (anoBissexto - 1)) * 365);
                                    }
                                    else
                                    {
                                        idadeDias = anoBissexto * 366 + ((idadeAnos - anoBissexto) * 365);
                                    }
                                    Console.WriteLine("Você possui {0} dias de idade", idadeDias);
                                }
                            }
                            else if (dataNascimento.Month > dataAtual.Month)
                            {
                                idadeAnos--;
                                if(bissexto==true)
                                {
                                    idadeDias = (anoBissexto - 1) * 366 + ((idadeAnos - (anoBissexto -          1)) * 365) + (diasAno - anoPassado.DayOfYear) + dataAtual.DayOfYear;
                                }
                                else
                                {
                                    idadeDias = anoBissexto * 366 + ((idadeAnos - anoBissexto) * 365) +         (diasAno - anoPassado.DayOfYear) + dataAtual.DayOfYear;
                                }
                                
                                Console.WriteLine("Você possui {0} dias de idade", idadeDias);
                            }
                            else
                            {
                                idadeDias = anoBissexto * 366 + ((idadeAnos - anoBissexto) * 365) + dataAtual.DayOfYear - diaNascAnoAtual.DayOfYear;
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
