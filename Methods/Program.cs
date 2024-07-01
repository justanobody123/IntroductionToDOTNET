using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int len = args.Length;
			//int[] arr = new int[len] { };
			//         //Console.WriteLine(Sum(2, 3));
			////Console.WriteLine(Sum(new int[] { 3,5,8,13,21,34}));
			//foreach (string i in args)
			//{
			//             Console.Write(i + "\t");
			//         }
			//Console.WriteLine(Sum(3, 5, 8, 13, 21, 34));
			List<int> l_numbers = new List<int>();
			foreach(string i in args)
			{
				l_numbers.Add(Convert.ToInt32(i));
			}
            Console.WriteLine(Sum(l_numbers.ToArray()));
			int a, b;
			//Exchange(ref a ,ref b);
            //Console.WriteLine(a + " " + b);
			Input(out a, out b);
            Console.WriteLine(a + " " + b);
        }
		static int Sum(int a,int b)
		{
			return a + b;
		}
		//static int Sum(int[] numbers)
		//{
		//	int sum = 0;
		//	foreach(int i in numbers)
		//	{
		//		sum += i;
		//	}
		//	return sum;
		//}
		static int Sum(params int[] numbers)
		{
			int sum = 0;
			foreach (int i in numbers)
			{
				sum += i;
			}
			return sum;
		}
		//ref должен быть проиницализированны до передачи в функцию
		//out функция инициализирует принимаемые параметры
		static void Input(out int a,  out int b)
		{
            Console.Write("Введите значение переменной a: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите значение переменной b: ");
			b = Convert.ToInt32(Console.ReadLine());
		}
		static void Exchange(ref int a, ref int b)
		{
			int buffer = a;
			 a = b;
			 b = buffer;
		}

	}
}
