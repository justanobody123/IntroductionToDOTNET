using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Псевдоквадрат
			int size = 5;
			for (int i = 0; i < size; i++)
			{
				for(int j = 0; j < size; j++) 
				{
					Console.Write("*");
				}
                Console.WriteLine();
            }
            Console.WriteLine();
            //Прямоугольный треугольник с острым углом слева
			for(int i = 0; i < size; i++)
			{
				for (int j = 0; j <= i; j++)
				{
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
			//Перевернутый прямоугольный треугольник с острым углом слева
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size - i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			//Перевернутый прямоугольный треугольник с острым углом справа
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (j < i)
					{
                        Console.Write(" ");
                    }
					else
					{
                        Console.Write("*");
                    }
				}
                Console.WriteLine();
            }
            Console.WriteLine();
			//Прямоугольный треугольник с острым углом справа
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (j < size - i - 1)
					{
                        Console.Write(" ");
                    }
					else
					{
                        Console.Write("*");
                    }
                }
				Console.WriteLine();
			}
            Console.WriteLine();
			//Ромб
			size = 10;
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (j == size / 2 - 1 - i || j == size - 1 - (i - size / 2))
					{
                        Console.Write("/");
                    } else if (i == size / 2 + j || j == size / 2 + i)
					{
                        Console.Write("\\");
                    }
					else 
					{
                        Console.Write(" ");
                    }
				}
                Console.WriteLine();
            }
            Console.WriteLine();
			//Чередующиеся + и -
			size = 5;
			for (int i = 0; i < size; i++)
			{
				for(int j = 0;j < size; j++)
				{
					if(i % 2 == 0 && j % 2 == 0 || i % 2 == 1 && j % 2 == 1)
					{
                        Console.Write("+");
                    } else 
					{ 
						Console.Write("-"); 
					}	
				}
                Console.WriteLine();
            }
            Console.WriteLine();
            //Цветная шахматная доска
            Console.Write("Введите размер шахматной доски: ");
            size = Convert.ToInt32(Console.ReadLine());
			for (int i = 0;i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (i % 2 == 0 && j % 2 == 0 || i % 2 == 1 && j % 2 == 1)
					{
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.White;
                        
                    } else
					{
						Console.ResetColor();
					}
					Console.Write("  ");
				}
                Console.WriteLine();
            }
			Console.ResetColor();
            Console.WriteLine();
			//Шахматная доска из символов
			Console.Write("Введите размер шахматной доски: ");
			size = Convert.ToInt32(Console.ReadLine());
			int square_size = 5;
			for (int i = 0; i < size * square_size; i++)
			{
				for(int j = 0; j < size * square_size; j++)
				{
					if (((i / square_size) + (j / square_size)) % 2 == 0)
					{
						Console.ForegroundColor = ConsoleColor.White;
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Black;
					}	

					Console.Write("* ");
                }
                Console.WriteLine();
            }
			Console.ResetColor();
            Console.WriteLine();
        }
	}
}
