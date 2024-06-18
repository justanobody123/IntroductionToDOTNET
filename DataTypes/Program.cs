﻿//#define INTEGRAL_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		static readonly string delimeter = "\n-------------------------------------------------\n\n";
		static void Main(string[] args)
		{
#if INTEGRAL_TYPES
			Console.WriteLine("ushort");
			Console.WriteLine($"Занимает {sizeof(ushort)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {ushort.MinValue} - {ushort.MaxValue}");
			Console.WriteLine(delimeter);

			Console.WriteLine("short");
			Console.WriteLine($"Занимает {sizeof(short)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {short.MinValue} - {short.MaxValue}");
			Console.WriteLine(delimeter);

			Console.WriteLine("uint");
			Console.WriteLine($"Занимает {sizeof(uint)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {uint.MinValue} - {uint.MaxValue}");
			Console.WriteLine(delimeter);

			Console.WriteLine("int");
			Console.WriteLine($"Занимает {sizeof(int)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {int.MinValue} - {int.MaxValue}");
			Console.WriteLine(delimeter);

			Console.WriteLine("ulong");
			Console.WriteLine($"Занимает {sizeof(ulong)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {ulong.MinValue} - {ulong.MaxValue}");
			Console.WriteLine(delimeter);

			Console.WriteLine("long");
			Console.WriteLine($"Занимает {sizeof(long)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {long.MinValue} - {long.MaxValue}");
			Console.WriteLine(delimeter); 
#endif
			Console.WriteLine("float");
			Console.WriteLine($"Занимает {sizeof(float)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {float.MinValue} - {float.MaxValue}");
			Console.WriteLine(delimeter);

			Console.WriteLine("double");
			Console.WriteLine($"Занимает {sizeof(double)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {double.MinValue} - {double.MaxValue}");
			Console.WriteLine(delimeter);

			Console.WriteLine("decimal");
			Console.WriteLine($"Занимает {sizeof(decimal)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {decimal.MinValue} - {decimal.MaxValue}");
			Console.WriteLine(delimeter);

			string line = Console.ReadLine(); // ввод числа в десятеричной системе 

			int x = int.Parse(line);

			string answer = "";
			int remainder;
			while (x != 0)
			{
				remainder = x % 16;
				if (remainder == 10) { answer += "a";}	
				else if (remainder == 11) { answer += "b"; }
				else if (remainder == 12) {  answer += "c"; }
				else if (remainder == 13) {  answer += "d"; }
				else if (remainder == 14) {  answer += "e"; }
				else if(remainder == 15) {  answer += "f"; }
				else { answer += remainder.ToString(); }
				x = x / 16;
			}
			//answer.Reverse();
			//Запишите тут Ваш код

			Console.WriteLine(answer);
		}
	}
}