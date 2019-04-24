using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sL1bExercicioEstCond10
{
    class Program
    {
        static void Main(string[] args)
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

            string nome;
            double altura, peso_ideal;
            string sexo;

            Console.WriteLine("\n--------PESO IDEAL--------\n");
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite seu sexo ('M' ou 'm' para Masculino | 'F' ou 'f' para Feminino): ");
            sexo = Console.ReadLine();

            if(sexo == "M" || sexo == "m")
            {
                peso_ideal = (72.7 * altura) - 58;
                Console.Write("{0}, seu peso Ideal é: {1}", nome, peso_ideal.ToString("N2"));
            }
            else if(sexo == "F" || sexo == "f")
            {
                peso_ideal = (62.1 * altura) - 44.7;
                Console.Write("{0}, seu peso Ideal é: {1}", nome, peso_ideal.ToString("N2"));
            }
            else
            {
                Console.WriteLine("Dados Inválidos");
            }
            Console.ReadKey();
        }
    }
}
