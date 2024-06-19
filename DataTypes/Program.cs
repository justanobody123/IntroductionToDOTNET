#define INTEGRAL_TYPES
//#define FLOATING_TYPES
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
			ushort _ushort = 0;
			Console.WriteLine($"Класс-обвертка: \t{_ushort.GetType()}");
			Console.WriteLine($"Занимает {sizeof(ushort)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {ushort.MinValue} - {ushort.MaxValue}");
			Console.WriteLine(delimeter);

			Console.WriteLine("short");
			short _short = 0;
			Console.WriteLine($"Класс-обвертка: \t{_short.GetType()}");
			Console.WriteLine($"Занимает {sizeof(short)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {short.MinValue} - {short.MaxValue}");
			Console.WriteLine(delimeter);

			Console.WriteLine("uint");
			uint _uint = 0;
			Console.WriteLine($"Класс-обвертка: \t{_uint.GetType()}");
			Console.WriteLine($"Занимает {sizeof(uint)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {uint.MinValue} - {uint.MaxValue}");
			Console.WriteLine(delimeter);

			Console.WriteLine("int");
			int _int = 0;
			Console.WriteLine($"Класс-обвертка: \t{_int.GetType()}");
			Console.WriteLine($"Занимает {sizeof(int)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {int.MinValue} - {int.MaxValue}");
			Console.WriteLine(delimeter);

			Console.WriteLine("ulong");
			ulong _ulong = 0;
			Console.WriteLine($"Класс-обвертка: \t{_ulong.GetType()}");
			Console.WriteLine($"Занимает {sizeof(ulong)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {ulong.MinValue} - {ulong.MaxValue}");
			Console.WriteLine(delimeter);

			Console.WriteLine("long");
			long _long = 0;
			Console.WriteLine($"Класс-обвертка: \t{_long.GetType()}");
			Console.WriteLine($"Занимает {sizeof(long)} байта");
			Console.WriteLine($"Диапазон принимаемых значений: {long.MinValue} - {long.MaxValue}");
			Console.WriteLine(delimeter); 
#endif

#if FLOATING_TYPES
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
#endif

			long a = 2;
			ulong b = 3;
            a = (int)b;
            //a = int(b); - syntax error
            //Console.WriteLine((a + b).GetType());

        }
	}
}
