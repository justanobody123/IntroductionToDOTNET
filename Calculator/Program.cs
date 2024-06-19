using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите выражение формата a ? b для вычисления или \"exit\" для выхода");
			while (true)
			{
				string userInput = Console.ReadLine();
				if (userInput == "exit")
				{
					break;
				}
				string[] expression = userInput.Split(new char[] { '+', '-', '/', '*' });
				if (expression.Length != 2)
				{
					Console.WriteLine("Можно вычислить выражение только из двух операндов.");
					continue;
				}
				double operand1, operand2;
				//Трай парс возвращает логическое значение и сам результат парсинга, если он успешен, в какую-то переменную с помощью оператора out
				//Трим без аргументов удаляет лишние пробелы по бокам
				if (!double.TryParse(expression[0].Trim(), out operand1) || !double.TryParse(expression[1].Trim(), out operand2))
				{
                    Console.WriteLine("Невозможно выявить операнд.");
					continue;
                }
				//Тут будет либо первый встреченный знак из массива, либо -1, который упадет в дефолт в свитче
				char op = userInput[userInput.IndexOfAny(new char[] { '+', '-', '*', '/' })];
				switch (op) 
				{
					case '+':
                        Console.WriteLine(operand1 + operand2);
						break;
					case '-':
						Console.WriteLine(operand1 - operand2);
						break;
					case '*':
						Console.WriteLine(operand1 * operand2);
						break;
					case '/':
						if (operand2 != 0)
						{
							Console.WriteLine(operand1 / operand2);
						}
						else 
						{
                            Console.WriteLine("Деление на ноль невозможно.");
                        }
						break;
					default:
						Console.WriteLine("Неподдерживаемый оператор.");
						break;
                }


			}
		}
		
	}
}
