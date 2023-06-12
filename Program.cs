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
            //Variavel para as operações
            char op;
            //Variavel para os valores numericos
            double num1, num2;
            //Variavel para repetição
            char yn = 'y';
            //Valores dos resultados
            double soma, subt, multi, divi;

            //Condicional para repetição do programa
            while (yn != 'n')
            {
                //Pergunta para o usuário o operador que o usuario vai usar
                Console.WriteLine("Entre com o operador +, -, *, /: ");
                //Faz a leitura dos valor da operação
                op = char.Parse(Console.ReadLine());
                //Pergunta o primeiro valor
                Console.WriteLine("Entre com o primeiro valor: ");
                //Faz a leitura do primeiro valor
                num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //Pergunta o valor do segundo numero
                Console.WriteLine("Entre com o segundo valor: ");
                //Faz a leitura do segundo valor
                num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Condicional para operadores
                switch (op)
                {
                    // Caso de soma
                    case '+':
                        //Variavel para mostrar a soma
                        soma = num1 + num2;
                        //Imprime para o usuario o resultado da soma
                        Console.WriteLine(num1 + " + " + num2 + " = " + soma);
                        //Quebra o resto
                        break;
                    // Caso de subtração
                    case '-':
                        //Variavel para mostrar a subtração
                        subt = num1 - num2;
                        //Imprime para o usuario o resultado da subtração
                        Console.WriteLine(num1 + " - " + num2 + " = " + subt);
                        //Quebra o resto
                        break;
                    //Caso para multiplicação
                    case '*':
                        //Variavel para mostrar a multiplicação
                        multi = num1 * num2;
                        //Imprime para o usuario o resultado da multiplicação
                        Console.WriteLine(num1 + " * " + num2 + " = " + num1 * num2);
                        //Quebra o resto
                        break;
                    //Caso para divisão
                    case '/':
                        //Variavel para mostrar a divisão
                        divi = num1 / num2;
                        //Imprime para o usuario o resultado da divisão
                        Console.WriteLine(num1 + " / " + num2 + " = " + num1 / num2);
                        //Quebra o resto
                        break;
                    //Padrão
                    default:
                        //Imprime para o usuario se ele usar o operador que não existe
                        Console.WriteLine("Operador errado, insira o operador correto dessa vez");
                        //Quebra o resto
                        break;

                }
                //Pergunta para o usuario se ele quer usar o programa novamente
                Console.WriteLine("Deseja continuar? y ou n: ");
                //Faz a leitura do valor inserido para ver se o programa vai parar ou não
                yn = char.Parse(Console.ReadLine());

            }



        }
    }
}
