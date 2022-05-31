using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Exercício 92 Leia2 vetores de inteiros V1 e V2 de N componentes
             *  cada(nomáximo50).Determine  imprima quantas vezes que V1 e V2 possuem valores idênticos nas mesmas posições
              */

            Console.WriteLine("Digite um numero que determinará o tamanho do vetor");
            int x = int.Parse(Console.ReadLine());

            if (x > 50)
            {
                do
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("<<ERROR>> \n o Numero nao pode ser maior que 50");
                    Console.ResetColor();

                    Console.WriteLine("Digite um numero que determinará o tamanho do vetor\n");
                    x = int.Parse(Console.ReadLine());
                }
                while (x > 50);
            }
            Console.Clear();
            int[] vetor1 = new int[x];
            int[] vetor2 = new int[x];




            Console.WriteLine("Matheus Rodrigues dos Santos RA 221282-6 - Exercicio 92");
        }
    }
}
