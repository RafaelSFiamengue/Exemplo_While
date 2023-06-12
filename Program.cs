//Biblioteca 
using System;
//Biblioteca
using System.Globalization;
//Biblioteca
namespace Course
{
    //Classe do programa
    public class Program
    {
        
        //Programa Principal
        public static void Main(string[] args)
        {
            //Declaração das variaveis dos valores
            double a, b;
            //Pergunta o primeiro valor para o usuario
            Console.WriteLine("Entre com o primeiro valor: ");
            //Faz a leitura do valor e atribui para a variavel a
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Pergunta o segundo valor para o usuario 
            Console.WriteLine("Entre com o segundo valor: ");
            //Faz a leitura do valor e atribui para a variavel b
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Imprime o valor da soma dos valores
            Console.WriteLine(Soma(a, b));
            //Imprime o valor da subtração dos valores
            Console.WriteLine(Subt(a, b));
            //Imprime o valor da Multiplicação dos valores
            Console.WriteLine(Multi(a, b));
            //Imprime o valor da Divisão dos valores
            Console.WriteLine(Divi(a, b));


        }
        //Função da soma
        public static double Soma(double a, double b)
        {
            //Variavel do valor da soma
            double ResultSm;
            //Calculo da soma
            ResultSm = a + b;
            //Retorna para o resultado
            return ResultSm;
        }
        //Função da subtração
        public static double Subt(double a, double b)
        {
            //Variavel do valor da subtração
            double ResultSb;
            //Calculo da subtração
            ResultSb = a - b;
            //Retorna para o resultado
            return ResultSb;
        }
        //Função da multiplicação
        public static double Multi(double a, double b)
        {
            //Variavel do valor da multiplicação
            double ResultMulti;
            //Calculo da multiplicação
            ResultMulti = a * b;
            //Retorna para o resultado
            return ResultMulti;
        }
        //Função da Divisão
        public static double Divi(double a, double b)
        {
            //Variavel do valor da divisão
            double ResultDivi;
            //Calculo da divisão 
            ResultDivi = a / b;
            //Retorna para o resultado
            return ResultDivi;
        }
    }
}
