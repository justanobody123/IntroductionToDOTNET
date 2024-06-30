using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_HW
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//TODO:
			//	1.В массиве, заполненном случайными числами, найти следующие значения:
			//	-Сумма;
			//	-Среднее - арифметическое;
			//	-Минимальное;
			//	-Максимальное;
			//	Все эти значения найти для одномерного, двумерного и зубчатого массива;
			//	2.Есть массив, заполненный случайными, значения в этом массиве повторяются.
			// Необходимо найти повторяющиеся значения, вывести их на экран, и вывести на экран
			// количество повторений для каждого значения;
			Random rand = new Random();

			Console.WriteLine("SINGLE_DIMENSIONAL_ARRAYS:");
			Console.WriteLine("\n----------задание №1----------");
            int size = 10, topLimit = 100;
			int[] SDarr = new int[10];
            for (int i = 0; i < SDarr.Length; i++) 
			{
				SDarr[i] = rand.Next(topLimit);
				Console.Write(SDarr[i] + " ");
			}
            Console.WriteLine();
            int sum = 0, min = int.MaxValue, max = int.MinValue;
			for (int i = 0;i < SDarr.Length; i++) 
			{
				sum += SDarr[i];
				if (min > SDarr[i])
				{
					min = SDarr[i];
				}
				if (max < SDarr[i])
				{
					max = SDarr[i];
				}
			}
			double arithmeticMean = sum / (double)size;
            Console.WriteLine($"Sum = {sum}\nArithmetic Mean =  {arithmeticMean}\nMin = {min}\nMax = {max} ");
			Console.WriteLine("\n----------задание №2----------");
			int bottomLimit = 95;
			for (int i = 0; i < SDarr.Length; i++)
			{
				SDarr[i] = rand.Next(bottomLimit, topLimit);
				Console.Write(SDarr[i] + " ");
			}
			Console.WriteLine();
			string result = "";
			int repeats = 0;
			for (int i = 0; i < SDarr.Length; i++)
			{
				if (!result.Contains($"Num {SDarr[i]}: "))
				{
					result += $"Num {SDarr[i]}: ";
					for (int j = 0; j < SDarr.Length; j++)
					{
						if (SDarr[j] == SDarr[i])
						{
							repeats++;
						}
					}
					result += $"{repeats}\n";
					repeats = 0;
				}
				else
				{
					continue;
				}
				
			}
			Console.WriteLine(result); 

			Console.WriteLine("MULTI_DIMENSIONAL_ARRAYS:");
			Console.WriteLine("\n----------задание №1----------");
			int rows = 3, cols = 5;
			int[,] MDarr = new int[rows, cols];
			for (int i = 0; i < rows; i++) 
			{
				for (int j = 0; j < cols; j++)
				{
					MDarr[i, j] = rand.Next(topLimit);
					Console.Write(MDarr[i,j] + " ");
				}
                Console.WriteLine();
            }
            Console.WriteLine();
			sum = 0; min = int.MaxValue; max = int.MinValue;
			foreach (int i in MDarr) 
			{
				sum += i;
				if (min > i)
				{
					min = i;
				}
				if (max < i)
				{
					max = i;
				}
			}
			arithmeticMean = sum / (double)(rows * cols);
			Console.WriteLine($"Sum = {sum}\nArithmetic Mean =  {arithmeticMean}\nMin = {min}\nMax = {max} ");
			Console.WriteLine("\n----------задание №2----------");
			for (int i = 0;i < rows;i++) 
			{
				for(int j = 0;j < cols;j++)
				{
					MDarr[i, j] = rand.Next(bottomLimit, topLimit);
					Console.Write(MDarr[i, j] + " ");
				}
                Console.WriteLine();
            }
            Console.WriteLine();
			result = "";
			repeats = 0;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (!result.Contains($"Num {MDarr[i, j]}: "))
					{
						result += $"Num {MDarr[i, j]}: ";
						for (int ii = 0; ii < rows; ii++)
						{
							for (int jj = 0; jj < cols; jj++)
							{
								if (MDarr[ii, jj] == MDarr[i, j])
								{
									repeats++;
								}
							}

						}
						result += $"{repeats}\n";
						repeats = 0;
					}
					else
					{
						continue;
					}
				}
			}
			Console.WriteLine(result);
			Console.WriteLine("JAGGED_ARRAYS:");
			Console.WriteLine("\n----------задание №1----------");
			rows = rand.Next(2, 6);
			int[][] Jarr = new int[rows][];
			for (int i = 0; i < rows; i++)
			{
				Jarr[i] = new int[rand.Next(1, 6)]; 
			}
			for (int i = 0;i < rows; i++)
			{
				for(int j = 0; j < Jarr[i].Length; j++)
				{
					Jarr[i][j] = rand.Next(topLimit);
					Console.Write(Jarr[i][j] + " ");
				}
                Console.WriteLine();
            }
            Console.WriteLine();
			sum = 0; min = int.MaxValue; max = int.MinValue;
			int amount = 0;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < Jarr[i].Length;j++) 
				{
					amount++;
					sum += Jarr[i][j];
					if (min > Jarr[i][j])
					{
						min = Jarr[i][j];
					}
					if (max < Jarr[i][j])
					{
						max = Jarr[i][j];
					}
				}
				
			}
			arithmeticMean = sum / (double)amount;
			Console.WriteLine($"Sum = {sum}\nArithmetic Mean =  {arithmeticMean}\nMin = {min}\nMax = {max} ");
			Console.WriteLine("\n----------задание №2----------");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < Jarr[i].Length; j++)
				{
					Jarr[i][j] = rand.Next(bottomLimit, topLimit);
					Console.Write(Jarr[i][j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			result = "";
			repeats = 0;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < Jarr[i].Length; j++)
				{
					if (!result.Contains($"Num {Jarr[i][j]}: "))
					{
						result += $"Num {Jarr[i][j]}: ";
						for (int ii = 0; ii < rows; ii++)
						{
							for (int jj = 0; jj < Jarr[ii].Length; jj++)
							{
								if (Jarr[ii][jj] == Jarr[i][j])
								{
									repeats++;
								}
							}

						}
						result += $"{repeats}\n";
						repeats = 0;
					}
					else
					{
						continue;
					}
				}
			}
			Console.WriteLine(result);
		}
	}
}
