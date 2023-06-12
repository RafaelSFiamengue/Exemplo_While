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
            //VAriavel para o valor do usuario e de i
            double num, i = 0;

            //Imprime para o usuario o perguntando o valor que ele quer usar
            Console.WriteLine("Digite um numero natural: ");
            //Faz a leitura do valor do usuario para a variavel
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Condicional de While para i ser menor ou igual ao valor do usuario
            while (i <= num)
            {
                //Imprime para o usuario o valores até chegar no valor do usuario
                Console.WriteLine(i + " ");
                //Contador
                i++;

            }
            
        }
    }
}//Vai tricolor