using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 90
            Considere um vetor de 10 números inteiros positivos maiores que zero e um único
            número inteiro, também positivo e maior que zero. Faça um programa para:
            a. ler pelo teclado o vetor;
            b. ler pelo teclado o número X;
            c. dizer quantos números no vetor são maiores que X , menores que X e iguais a X.
            */
            Console.WriteLine("Matheus Rodrigues dos Santos RA 221282-6 - Exercicio 90");            

            int[]numeros = new int[10];
            int maiores=0, menores=0, iguais=0;
            int n = 0;
            
            
            for (n=0;n<numeros.Length;n++)
            {
                Console.WriteLine("Querido usuario entre com um numero inteiro ");
                int temp = int.Parse(Console.ReadLine());
                numeros[n] = temp;
            }
            Console.WriteLine("--------------------------- ");
            Console.WriteLine("Agora digite com um numero X!\nesse numero ja nao faz parte do vetor ");
            Console.WriteLine("--------------------------- ");
            Console.WriteLine("Querido usuario entre com um numero para a variavel X ");
            int x = int.Parse(Console.ReadLine());

            
            for(n = 0; n < numeros.Length; n++)
            {
                if (numeros[n] > x)
                {
                    maiores = maiores + 1;
                }
                else if (numeros[n] < x)
                {
                    menores = menores + 1;
                }
                else
                {
                    iguais = iguais + 1;
                }
            }
            Console.WriteLine("Numeros maiores: "+maiores);
            Console.WriteLine("Numeros menores: "+menores);
            Console.WriteLine("Numeros iguais: "+ iguais);

        }
    }
}
