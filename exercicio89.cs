using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 89
                Dada uma sequência de n números (vetor de inteiros),
                imprimi-la na ordem inversa que foi realizada a leitura.
            */
            Console.WriteLine("Matheus Rodrigues dos Santos RA 221282-6 - Exercicio 89");            

            int[]numeros = new int[10];
            int n = 0;

            for (n=0;n<numeros.Length;n++)
            {
                Console.WriteLine("Querido usuario entre com um numero inteiro ");
                int temp = int.Parse(Console.ReadLine());
                numeros[n] = temp;
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("O array digitado inversamente: ");
            Console.WriteLine("--------------------");
            for ( n = 9; n >=0; n--)
            {
                Console.WriteLine(numeros[n]);
            }
            
        }
    }
}
