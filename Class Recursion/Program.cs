using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				Console.WriteLine($"{n}! = {Factorial(n)}");
			}
			catch (Exception ex)
			{

                Console.WriteLine($"{ex.GetType()}: {ex.Message}");
            }
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
		static long Factorial(long n)
		{
			if (n <= 1) return 1;
			long f = n * Factorial(n - 1);
			Console.WriteLine($"{n}! = {f}");
			return f;
		}
	}
}
