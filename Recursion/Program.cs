
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
	internal class Program
	{
		static ulong Factorial(uint number)
		{
			if (number <= 1) return 1;
			else return number * Factorial(number - 1);
		}
		static double Power(double number, int power)
		{
			if (power == 0) return 1;//Все что угодно в нулевой степени = 1.
			else if (power > 0) return number * Power(number, power - 1);//Для положительных степеней.
			else return 1 / Power(number, -power);//Для отрицательных степеней.
			//Мне не хочется пытаться прописывать условие для возведение в дробную степень, потому что я плохо помню логарифмы и экспоненты, а времени их повторять у меня нет.
        }
		static void PrintFibonacci(uint limit, uint current = 0, uint next = 1)
		{
			if (current <= limit)
			{
				Console.Write(current + " "); 
				PrintFibonacci(limit, next, current + next);
			}
        }
		static void PrintFibonacci1(int amount, uint current = 0, uint next = 1)
		{
			if (amount > 0)
			{
				Console.Write(current + " "); 
				PrintFibonacci1(amount - 1, next, current + next);
			}
        }
		static void Main(string[] args)
		{
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Power(5, -2));
			//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, …,
			PrintFibonacci(5);
            Console.WriteLine();
            PrintFibonacci1(5);

        }
	}
}
