using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//using System.Exception;
namespace Class_Recursion
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //Console.Write("Введите номер этажа: ");
            //int floor = Convert.ToInt32(Console.ReadLine());
            //Elevator(floor);
            Console.Write("Введите число: ");
			long n = Convert.ToInt64(Console.ReadLine());
			try
			{
				DateTime start = DateTime.Now;
				Console.WriteLine($"{n}! = {Factorial(n)}");
				DateTime end = DateTime.Now;
				TimeSpan duration = end - start;
                Console.WriteLine($"Duration: {duration.ToString("g")}");
            }
			catch (StackOverflowException ex)
			{
                Console.WriteLine($"{ex.GetType()}: {ex.Message}");
            }
			catch(Exception ex)
			{
				Console.WriteLine($"{ex.GetType()}: {ex.Message}");
			}
            Console.WriteLine("Calculation DONE");
        }
		static void Elevator(int floor)
		{
			if (floor == 0)
			{
                Console.WriteLine("Вы в подвале.");
                return;
			}

            Console.WriteLine($"Вы на {floor} этаже.");
            Elevator(floor - 1);
			Console.WriteLine($"Вы на {floor} этаже.");
		}
		static BigInteger Factorial(long n)
		{
			BigInteger f = 1;
			for (int i = 2; i <= n; i++)
			{
				f *= i;
			}
			return f;
			//if (n <= 1) return 1;
			//try
			//{
			//	BigInteger f = n * Factorial(n - 1);
			//	return f;
			//}
			//catch (Exception ex)
			//{

			//	throw ex;
			//}
			////Console.WriteLine($"{n}! = {f}");

		}
	}
}
