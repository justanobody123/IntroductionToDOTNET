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
			ulong n = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine($"{n}! = {Factorial(n)}");
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
		static double Factorial(double n)
		{
			if (n <= 1) return 1;
			double f = n * Factorial(n - 1);
			Console.WriteLine($"{n}! = {f}");
			return f;
		}
	}
}
