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
            //Variavel para o valor num
            double num;
            //Faça
            do
            {
                //Imprime para o usuario o perguntando o valor que ele quer usar entre 1 a 10
                Console.WriteLine("Digite um numero entre 1 a 10: ");
                //Faz a leitura do valor do usuario para a variavel
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //Condicional de While para o valor de num estar entre 1 e 10
            while (num < 1 || num > 10);
                //Imprime para o usuario o número que ele digitou
                Console.WriteLine("Você digitou o numero " + num + ".");
            
            
        }
    }
}