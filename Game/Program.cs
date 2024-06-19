using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	internal class Program
	{
		class Square
		{
			int size;
			ConsoleColor color;
			int x;
			int y;
			private int checkSize(int value)
			{
				if (value <= 0) { value = 1; }
				else if (value > 10) { value = 10; }
				return value;
				
			}
			//От 1 до 10
			public void setSize(int size) { this.size = checkSize(size); }
			public void setColor(ConsoleColor color) { this.color = color; }
			private int checkX(int x) 
			{ 
				if (x <= 0) 
				{ 
					x = 0;
				}
				else if (x > (120 - (this.size * 2))) 
				{ 
					x = 120 - size * 2; 
				}
				return x; 
			}
			private int checkY(int y)
			{
				if(y < 0) 
				{
					y = 0;
				}
				else if(y > 30 - this.size)
				{
					y = 30 - this.size;
				}
				return y;
			}
			public void setPosition(int x, int y)
			{
				this.x = checkX(x);
				this.y = checkY(y);
			}
			public int getX() { return x; }
			public int getY() { return y; }
			public int getSize() { return size; }
			public ConsoleColor getColor() { return color; }
			public void print()
			{
				Console.BackgroundColor = color;
				Console.ForegroundColor = color;
				for (int i = 0; i < size; i++) 
				{ 
					Console.SetCursorPosition(x, y + i);
					for(int j = 0; j < size; j++) 
					{
                        Console.Write("  ");
                    }
                }
				Console.ResetColor();
			}
			public void clear()
			{
				Console.ForegroundColor = ConsoleColor.Black;
				for (int i = 0; i < size; i++)
				{
					Console.SetCursorPosition(x, y + i);
					for (int j = 0; j < size; j++)
					{
						Console.Write("  ");
					}
					Console.WriteLine();
				}
				Console.ResetColor();
			}
			public void move()
			{
				ConsoleKeyInfo key;
				do
				{
					print();
					key = Console.ReadKey(true);
					clear();
					switch (key.Key) 
					{
						case ConsoleKey.UpArrow:
						case ConsoleKey.W:
							y = checkY(y-1); 
							break;
						case ConsoleKey.DownArrow:
						case ConsoleKey.S:
							y = checkY(y+1);
							break;
						case ConsoleKey.LeftArrow:
						case ConsoleKey.A:
							x = checkX(x-1);
							break;
						case ConsoleKey.RightArrow:
						case ConsoleKey.D:
							x = checkX(x+1);
							break;
						default:
							break;
					}
				} while (key.Key != ConsoleKey.Escape);
			}
			public Square()
			{
				x = 0;
				y = 0;
				size = 5;
				color = ConsoleColor.White;
			}
			~Square()
			{

			}
		};
		static void Main(string[] args)
		{
			Square square = new Square();
			square.move();
		}
	}
}
