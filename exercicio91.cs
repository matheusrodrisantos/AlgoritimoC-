using System;

using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  Exercício91 Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza. Foram inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade.Tais informações foram armazenadas em 2 vetores distintos. Faça um programa para imprima o vetor 
           *  que contém os nomes das candidatas aptas a concorrer a uma vaga paraa campanha milionária.
            */
           
            

            Console.WriteLine("-------------------------");
            for (int i=0;i<15;i++)
            {
                Console.WriteLine("- Agencia Luz e Belezaaa  -");
                Thread.Sleep(100);
            }

            Thread.Sleep(1000);
            
            Console.Clear();
            Console.WriteLine("Bem vindo ao concurso agencia de Modelo Luz e Beleza");

            string[] nome = new string[2];
            int[] idade = new int[2];


            for(int n=0;n<nome.Length;n++)
            {
                Console.WriteLine("Digite o nome\n------\n");
                nome[n]=Console.ReadLine();

                Console.WriteLine("Digite a idade\n------\n");
                idade[n] = int.Parse(Console.ReadLine());   
            }

            for (int n = 0; n < nome.Length; n++)
            {
                if (idade[n]>=18 && idade[n] <= 20)
                {
                    Console.WriteLine("Nome da candidata:"+nome[n]);
                }
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Matheus Rodrigues dos Santos RA 221282-6 - Exercicio 91");

        }
    }
}
