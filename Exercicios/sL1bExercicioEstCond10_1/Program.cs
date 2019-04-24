using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1bExercicioEstCond10_1
{
    /*10) Para o enunciado a seguir foi elaborado um Programa em C# que contém erros, identifique os erros corrija-os e execute o Programa:  
                Enunciado: Tendo como dados de entrada o nome, a altura e o sexo (M ou F) de uma pessoa, calcule e mostre seu peso ideal, utilizando as seguintes fórmulas:  
                * - para sexo masculino:  peso ideal = (72.7 * altura) - 58  
                * - para sexo feminino:  peso ideal = (62.1 * altura) - 44.7   
                static void Main(string[] args) 
                { 
                    nome = Console.ReadLine()      
                    sexo = Console.Read()      
                    if (sexo = M)      
                    {       
                        peso_ideal = (72.7 * altura) - 58 
                    }      
                    else      
                    {       
                        peso_ideal = (62.1 * altura) – 44.7 
                    }      
                    Console.Write("Seu peso Ideal é: ", peso_ideal); 
                } */
    public class PesoIdeal
    {
        string nome;
        double altura;
        string sexo;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public double CalcularPesoIdeal(string sexo, double altura)
        {
            //Inicializando a variável peso_ideal com 0 pra poder retornar um valor para a função antes da verificação da condição
            double peso_ideal = 0.0;

            if(sexo=="M" || sexo=="m")
            {
                peso_ideal = (72.7 * altura) - 58;
            }
            else if(sexo=="F" || sexo=="f")
            {
                peso_ideal = (62.1 * altura) - 44.7;
            }
            return peso_ideal;
        }
        public void Resultado(string nome, double peso_ideal)
        {
            Console.Write("{0}, seu peso Ideal é: {1}", nome, peso_ideal.ToString("N2"));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PesoIdeal pessoa1 = new PesoIdeal();

            Console.WriteLine("\n--------PESO IDEAL--------\n");
            Console.Write("Digite seu nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Digite sua altura: ");
            pessoa1.Altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite seu sexo ('M' ou 'm' para Masculino | 'F' ou 'f' para Feminino): ");
            pessoa1.Sexo = Console.ReadLine();

            pessoa1.Resultado(pessoa1.Nome, pessoa1.CalcularPesoIdeal(pessoa1.Sexo, pessoa1.Altura));
            Console.ReadKey();
        }
    }
}
