using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Matheus Rodrigues dos Santos RA 221282-6 - Exercicio 88");            
           

            int[]numeros = new int[10];
            int n = 0;

            for (n=0;n<numeros.Length;n++)
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp>0)
                {
                    numeros[n] = temp;
                }
                else
                {
                    Console.WriteLine("\nError");
                    int x;
                    do
                    {
                        Console.WriteLine("Entre com um numero inteiro positivo");
                        x = int.Parse(Console.ReadLine());
                        if (x>0)
                        {
                            numeros[n] = x;
                            break;
                        }
                    }while(x>0);
                }
                Console.WriteLine("Entre com um numero inteiro positivo");
            }

            //exibir os numeros pares e impares 
            for ( n = 0; n < numeros.Length; n++)
            {
                if (numeros[n]%2==0)
                {
                    Console.WriteLine("numero par: "+numeros[n]);
                }
            }

            for ( n = 0; n < numeros.Length; n++)
            {
                if (numeros[n] % 2 != 0)
                {
                    Console.WriteLine("numero impar: " + numeros[n]);
                }
            }
        }
    }
}
