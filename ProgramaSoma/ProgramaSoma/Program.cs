using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeiroNumero, segundoNumero;
            int numero1, numero2, soma;

            Console.WriteLine("*******************************************************");
            Console.WriteLine("***********PROGRAMA PARA SOMAR DOIS NUMEROS************");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();

            //solicitando para o usuario o numero
            Console.Write("Por favor entre com o Primeiro Número:");
            primeiroNumero = Console.ReadLine();

            //solicitando para o usuario o segundo numero
            Console.Write("Por favor entre com o segundo Número:");
            segundoNumero = Console.ReadLine();

            //convertendo os numeros de string para int
            numero1 = Int32.Parse(primeiroNumero);
            numero2 = Int32.Parse(segundoNumero);

            //somando os números
            soma = numero1 + numero2;

            //exibindo o resultado para o usuário
            Console.WriteLine("\nA Soma dos numeros foi: " + soma);

            //fim do programa
            Console.WriteLine();
            Console.WriteLine("Fim...");
            Console.WriteLine("Usuario  - Favor Pressionar uma Tecla para SAIR...");
            Console.ReadKey();


        }
    }
}
