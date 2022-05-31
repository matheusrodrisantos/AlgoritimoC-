using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Façaumprogramaqueleiaumastringeaimprimacadaletraseparadaporumtraço
            Console.WriteLine("Matheus Rodrigues dos Santos RA 221282-6 - Exercicio 104");

            Console.WriteLine("Digite um texto");
            string texto = Console.ReadLine();
            Console.WriteLine("Texto em minusculo");
            Console.WriteLine(texto.ToLower());
            Console.WriteLine("Texto em maiusculo");
            Console.WriteLine(texto.ToUpper());

            for (int n=0;n<texto.Length;n++)
            {
                Console.Write(texto[n]);
                if (n!=texto.Length-1)
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine('\n');

        }
    }
}
