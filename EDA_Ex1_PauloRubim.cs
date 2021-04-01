using System;
using System.Diagnostics;

namespace Atividade1
{
	public class EDA1
	{
		public static void Main()
		{
			// 
			int[] vetor1 = new int[1000];//AS ITERAÇÕES COM BASE NO VETOR 
			int[] vetor2 = new int[5000];//AS ITERAÇÕES COM BASE NO VETOR 
			
			Random x = new Random();
			Stopwatch stopwatch = new Stopwatch();//CRIANDO MARCADOR TEMPORAL 
			
			var r = System.Diagnostics.Stopwatch.StartNew();
			// -----1000
			stopwatch.Start();//MARCADOR TEMPORAL 
			
			for (int i = 0; i < vetor1.Length; i++)//ESTRUTURA DE REPETIÇÃO 1 
			{
				vetor1[i] = x.Next(1, 1000);
			}

			bubbleSort(vetor1, vetor1.Length);
			Console.WriteLine("\n\nVetor Ordenado pelo bubbleSort para 1000 valores\n");//IMPRIMINDO OS VALORES DE ITERAÇÕES 
			for (int i = 0; i < vetor1.Length; i++)//ESTRUTURA DE REPETIÇÃO 2 
			{
				Console.Write("{0} ", vetor1[i]);
			}

			r.Stop();//MARCADOR TEMPORAL 
			Console.WriteLine("\n\nTempo Decorrido do bubbleSort: {0}", r.Elapsed);//IMPRIMINDO OS VALORES DE ITERAÇÕES
			if (!r.IsRunning) //ESTRUTURA DE DECISÃO 1
				r.Restart();//MARCADOR TEMPORAL 
			insertionSort(vetor1, vetor1.Length);
			Console.WriteLine("\n\nVetor Ordenado pelo insertionSort para 1000 valores\n");//IMPRIMINDO OS VALORES DE ITERAÇÕES;
			for (int i = 0; i < vetor1.Length; i++)//ESTRUTURA DE REPETIÇÃO 3
			{
				Console.Write("{0} ", vetor1[i]);
			}

			r.Stop();//MARCADOR TEMPORAL 
			Console.WriteLine("\n\nTempo Decorrido do insertionSort: {0}", r.Elapsed);
			if (!r.IsRunning)//ESTRUTURA DE DECISÃO 2
				r.Restart();//MARCADOR TEMPORAL 
			selectionSort(vetor1, vetor1.Length);
			Console.WriteLine("\n\nVetor Ordenado pelo selectionSort para 1000 valores\n");//IMPRIMINDO OS VALORES DE ITERAÇÕES
			for (int i = 0; i < vetor1.Length; i++)//ESTRUTURA DE REPETIÇÃO 4
			{
				Console.Write("{0} ", vetor1[i]);
			}

			r.Stop();//MARCADOR TEMPORAL 
			Console.WriteLine("\n\nTempo Decorrido do selectionSort: {0}", r.Elapsed);
			if (!r.IsRunning)//ESTRUTURA DE DECISÃO 3 
				r.Restart();//MARCADOR TEMPORAL 
			quickSort(vetor1);
			Console.WriteLine("\n\nVetor Ordenado pelo quickSort para 1000 valores\n");//IMPRIMINDO OS VALORES DE ITERAÇÕES
			for (int i = 0; i < vetor1.Length; i++)//ESTRUTURA DE REPETIÇÃO 5
			{
				Console.Write("{0} ", vetor1[i]);
			}

			r.Stop();//MARCADOR TEMPORAL 
			Console.WriteLine("\n\nTempo Decorrido do quickSort: {0}", r.Elapsed);
			if (!r.IsRunning)//ESTRUTURA DE DECISÃO 4 
				r.Restart();//MARCADOR TEMPORAL 
			//5000
			for (int i = 0; i < vetor2.Length; i++)//ESTRUTURA DE REPETIÇÃO 6 
			{
				vetor2[i] = x.Next(1, 5000);
			}

			bubbleSort(vetor2, vetor2.Length);
			Console.WriteLine("\n\nVetor Ordenado pelo bubbleSort para 5000 valores\n");//IMPRIMINDO OS VALORES DE ITERAÇÕES
			for (int i = 0; i < vetor2.Length; i++)//ESTRUTURA DE REPETIÇÃO 7
			{
				Console.Write("{0} ", vetor2[i]);
			}

			r.Stop();//MARCADOR TEMPORAL 
			Console.WriteLine("\n\nTempo Decorrido do bubbleSort: {0}", r.Elapsed);
			if (!r.IsRunning)//ESTRUTURA DE DECISÃO 5
				r.Restart();//MARCADOR TEMPORAL 
			insertionSort(vetor2, vetor2.Length);
			Console.WriteLine("\n\nVetor Ordenado pelo insertionSort para 5000 valores\n");//IMPRIMINDO OS VALORES DE ITERAÇÕES
			for (int i = 0; i < vetor2.Length; i++)//ESTRUTURA DE REPETIÇÃO 8
			{
				Console.Write("{0} ", vetor2[i]);
			}

			r.Stop();//MARCADOR TEMPORAL V
			Console.WriteLine("\n\nTempo Decorrido do insertionSort: {0}", r.Elapsed);
			if (!r.IsRunning)//ESTRUTURA DE DECISÃO 6
				r.Restart();//MARCADOR TEMPORAL 
			selectionSort(vetor2, vetor2.Length);
			Console.WriteLine("\n\nVetor Ordenado pelo selectionSort para 5000 valores\n");//IMPRIMINDO OS VALORES DE ITERAÇÕES
			for (int i = 0; i < vetor2.Length; i++)//ESTRUTURA DE REPETIÇÃO 9 
			{
				Console.Write("{0} ", vetor2[i]);
			}

			r.Stop();//MARCADOR TEMPORAL 
			Console.WriteLine("\n\nTempo Decorrido do selectionSort: {0}", r.Elapsed);
			if (!r.IsRunning)//ESTRUTURA DE DECISÃO 7
				r.Restart();//MARCADOR TEMPORAL 
			quickSort(vetor2);
			Console.WriteLine("\n\nVetor Ordenado pelo quickSort para 5000 valores\n");//IMPRIMINDO OS VALORES DE ITERAÇÕES
			for (int i = 0; i < vetor2.Length; i++)//ESTRUTURA DE REPETIÇÃO 10 
			{
				Console.Write("{0} ", vetor2[i]);
			}

			r.Stop();//MARCADOR TEMPORAL 
			Console.WriteLine("\n\nTempo Decorrido do quickSort: {0}", r.Elapsed);
			if (!r.IsRunning)//ESTRUTURA DE DECISÃO 8
				r.Restart();//MARCADOR TEMPORAL 
			stopwatch.Stop();
			Console.WriteLine("\n\nO Tempo total Decorrido: {0}", stopwatch.Elapsed);
		}

		static void bubbleSort(int[] vetor, int length)
		{
			int trocas = 0;
			for (int i = 0; i < length - 1; i++)
			{
				for (int j = 0; j < length - 1; j++)
				{
					if (vetor[j] > vetor[j + 1])//ESTRUTURA DE DECISÃO 9
					{
						trocas = vetor[j];
						vetor[j] = vetor[j + 1];
						vetor[j + 1] = trocas;
					}
				}
			}
		}

		static void insertionSort(int[] vetor, int length)
		{
			int j, atual = 0;
			for (int i = 0; i < length; i++)
			{
				atual = vetor[i];
				j = i - 1;
				while (j >= 0 && vetor[j] > atual)
				{
					vetor[j + 1] = vetor[j];
					j = j - 1;
				}

				vetor[j + 1] = atual;
			}
		}

		static int[] selectionSort(int[] vetor, int length)
		{
			int min, aux;
			for (int i = 0; i < length - 1; i++)
			{
				min = i;
				for (int j = i + 1; j < length; j++)
				{
					if (vetor[j] < vetor[min])//ESTRUTURA DE DECISÃO 10
						min = j;
				}

				if (min != i)//ESTRUTURA DE DECISÃO 11
				{
					aux = vetor[min];
					vetor[min] = vetor[i];
					vetor[i] = aux;
				}
			}

			return vetor;
		}

		public static int[] quickSort(int[] vetor)
		{
			int inicio = 0;
			int fim = vetor.Length - 1;
			quickSort(vetor, inicio, fim);
			return vetor;
		}

		private static void quickSort(int[] vetor, int inicio, int fim)
		{
			if (inicio < fim)//ESTRUTURA DE DECISÃO 12
			{
				int p = vetor[inicio];
				int i = inicio + 1;
				int f = fim;
				while (i <= f)
				{
					if (vetor[i] <= p)//ESTRUTURA DE DECISÃO 13
					{
						i++;
					}
					else if (p < vetor[f])//ESTRUTURA DE DECISÃO 14
					{
						f--;
					}
					else//ESTRUTURA DE DECISÃO 15
					{
						int troca = vetor[i];
						vetor[i] = vetor[f];
						vetor[f] = troca;
						i++;
						f--;
					}
				}

				vetor[inicio] = vetor[f];
				vetor[f] = p;
				quickSort(vetor, inicio, f - 1);
				quickSort(vetor, f + 1, fim);
			}
		}
	}
}