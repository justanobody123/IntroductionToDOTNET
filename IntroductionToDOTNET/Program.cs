//#define CLASS_CONSOLE
//#define STRINGS
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if CLASS_CONSOLE
			Console.Title = "Введение в .NET";
			Console.WriteLine("Hello, .NET");
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.DarkGray;
			//Console.SetCursorPosition(22, 11);
			Console.CursorLeft = 22;
			Console.CursorTop = 11;
			Console.Beep(137, 2000);
			Console.Clear();
			Console.WriteLine("Привет, .NET");
			Console.ResetColor();
#endif
#if STRINGS
			Console.Write("Введите ваше имя: ");
			string first_name = Console.ReadLine();
			Console.Write("Введите вашу фамилию: ");
			string last_name = Console.ReadLine();
			Console.Write("Введите ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());
			#region ConsoleWriteRegion
			//Console.Write(first_name + " ");
			//Console.Write(last_name + " ");
			//Console.Write(age);
			//Console.WriteLine();//cout << endl; 
			#endregion
			//Console.WriteLine(first_name + " " + last_name + " " + age + "\n");//String Concatenation
			//Console.WriteLine(string.Format("{0} {1} {2}", last_name, first_name, age)); //String Formatting
			Console.WriteLine($"{last_name} {first_name} {age}"); //Strings Interpolation  
#endif

		}
	}
}
