using System;
using System.Text;

namespace MeuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine();


            //Método da função Console pra trocar a cor da fonte
            //trocando a cor da fonte dentro do console
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mudando a cor do texto do console para Verde!");
            Console.Write("Olá Mundo!!!!\n");
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Mudando a cor do texto do console para Vermelho!");
            Console.WriteLine("Meu nome é José Márcio");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Mudando a cor do texto do console para Branco!");
            Console.WriteLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine("************Aula 02 - Variáveis**********");
            Console.WriteLine("*****************************************");
            Console.WriteLine();

            int a = 100;
            Console.WriteLine("Valor da Variável a: " + a);
            Console.WriteLine();

            double area = 0;
            Console.WriteLine("Valor da Variável area: " + area);
            Console.WriteLine();

            int contador = 10;
            Console.WriteLine("Valor da Variável contador: " + contador);
            Console.WriteLine();

            string nome = "Marcio";
            Console.WriteLine("Valor da Variável nome: " + nome);
            Console.WriteLine();

            string nomeCompleto = "Visual Studio";
            Console.WriteLine("Valor da Variável nomeCompleto: " + nomeCompleto);
            Console.WriteLine();

            Console.WriteLine("*****************************************");
            Console.WriteLine("*********Pegar dados do teclado**********");
            Console.WriteLine("*****************************************");
            Console.WriteLine();

            Console.WriteLine("Favor digitar seu nome:");
            string nomeCompletoUsuario = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("O Nome digitado foi: " + nomeCompletoUsuario);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Fim");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            //método da função Console que aguarda uma tecla a ser pressionada
            Console.Write("Pressione uma Tecla para sair...");
            Console.ReadKey();
        }
    }
}
