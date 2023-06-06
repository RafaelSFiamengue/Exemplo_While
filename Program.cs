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
            
            //Imprime para o usuario o perguntando o valor entre os numeros naturais que ele quer usar
            Console.WriteLine("Digite um numero natural: ");

            //Faz a leitura do valor do usuario para a variavel
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Imprime para o usuarios a quantidade de numeros pares que ele escolheu
            Console.WriteLine("Os primeiros " + num + " numeros pares são");

            //Condição de for para aparecer a contagem de 2 em 2
            for (int i = 2; i < num * 2; i += 2)
            {
                //Imprime os números pares para o usuário
                Console.WriteLine(i + "");
            }
            
            
        }
    }
}