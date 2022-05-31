using System;
					
public class Program
{
	public static void Main()
	{	
		/*  Exercício 92 Leia2 vetores de inteiros V1 e V2 de N componentes
             *  cada(nomáximo50).Determine  imprima quantas vezes que V1 e V2 possuem valores idênticos nas mesmas posições
              */

            Console.WriteLine("Digite um numero que determinará o tamanho do vetor");
            int x = int.Parse(Console.ReadLine());
			int n;
            if (x > 50)
            {
                do
                {
                    //Console.BackgroundColor = ConsoleColor.Red;
                   // Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("<<ERROR>> \n o Numero nao pode ser maior que 50");
                   // Console.ResetColor();

                    Console.WriteLine("Digite um numero que determinará o tamanho do vetor\n");
                    x = int.Parse(Console.ReadLine());
                }
                while (x > 50);
            }
		
            Console.Clear();
			int[] vetor1 = new int[x];
            int[] vetor2 = new int[x];
		
		    for(n=0;n<x;n++)
			{
				Console.WriteLine("Digite um numero para o primeiro vetor\n");
				vetor1[n]= int.Parse(Console.ReadLine());
				
				Console.WriteLine("Digite um numero para o segundo vetor\n");
				vetor2[n]= int.Parse(Console.ReadLine());
			}
			int contador=0;
			for(n=0;n<x;n++)
			{
				if(vetor1[n]==vetor2[n])
				{
					contador++;
				}
			}
            
		   Console.Clear();
		   Console.WriteLine("Quantidade de vezes que os vetores tem o mesmo dado na mesma posicao e:"+contador);
           Console.WriteLine("Matheus Rodrigues dos Santos RA 221282-6 - Exercicio 92");
		   Console.WriteLine("https://github.com/matheusrodrisantos");
	}
}
