using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
	internal class Program
	{
		class Game
		{
			char cross = 'X';
			char nought = 'O';
			int gridSize = 6;
			const int fieldSize = 3;//Массив поля орет на меня: "хочу константу". Вот, пожалуйста
			int[,] field = new int[fieldSize, fieldSize];// { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
			int cursorX = 0;
			int cursorY = 0;
			int gridX = 0;
			int gridY = 0;
			int playerChoice;
			int botChoice;
			int filledCell = 0;
			readonly int[][] winCombinations = new int[][]//Так, насколько я поняла, обзываются константы не для примитивных типов данных.
			{
							  //i, j
				new int[] { 0, 0, 0, 1, 0, 2}, //th
				new int[] { 1, 0, 1, 1, 1, 2}, //mh
				new int[] { 2, 0, 2, 1, 2, 2}, //bh
				new int[] { 0, 0, 1, 0, 2, 0}, //lv
				new int[] { 0, 1, 1, 1, 2, 1}, //mv
				new int[] { 0, 2, 1, 2, 2, 2}, //rv
				new int[] { 0, 0, 1, 1, 2, 2}, //+x+yd
				new int[] { 0, 2, 1, 1, 2, 0} //-x+yd
			};
			void CleanGame()
			{
				for (int i = 0; i < fieldSize; i++)
				{
					for (int j = 0; j < fieldSize; j++)
					{
						field[i, j] = 0;
					}
				}
				filledCell = 0;
				cursorX = 0;
				cursorY = 0;
			}
			void PrintGrid()
			{
				for (int i = 0; i < fieldSize; i++)
				{
					Console.SetCursorPosition(gridX, gridY + i * 2);
					for (int j = 0; j < fieldSize; j++)
					{
						if (i == cursorY && j == cursorX)
						{
							Console.BackgroundColor = ConsoleColor.White;
							Console.ForegroundColor = ConsoleColor.Black;
						}
						if (field[i, j] == 0) Console.Write(" ");
						else if (field[i, j] == 1) Console.Write(cross);
						else if (field[i, j] == 2) Console.Write(nought);
						Console.ResetColor();
						if (j < 2)
						{
							Console.Write("|");
						}
					}
					Console.SetCursorPosition(gridX, gridY + i * 2 + 1);
					if (i < 2) Console.WriteLine("_|_|_");
					else Console.WriteLine(" | | ");
				}
			}
			int CheckX(int x)
			{
				return x < 0 ? 0 : x > fieldSize - 1 ? fieldSize - 1 : x;
			}
			int CheckY(int y)
			{
				return y < 0 ? 0 : y > fieldSize - 1 ? 2 : y;
			}
			void MakeMove()
			{
				bool isCorrect = false;
				ConsoleKeyInfo key;
				do
				{
					PrintGrid();
					key = Console.ReadKey(true);
					Console.Clear();
					switch (key.Key)
					{
						case ConsoleKey.Escape:
							Environment.Exit(0);
							break;
						case ConsoleKey.W:
						case ConsoleKey.UpArrow:
							cursorY = CheckY(cursorY - 1);
							break;
						case ConsoleKey.S:
						case ConsoleKey.DownArrow:
							cursorY = CheckY(cursorY + 1);
							break;
						case ConsoleKey.A:
						case ConsoleKey.LeftArrow:
							cursorX = CheckX(cursorX - 1);
							break;
						case ConsoleKey.D:
						case ConsoleKey.RightArrow:
							cursorX = CheckX(cursorX + 1);
							break;
						case ConsoleKey.Enter:
							if (field[cursorY, cursorX] == 0)
							{
								field[cursorY, cursorX] = playerChoice;
								isCorrect = true;
							}
							break;
					}
				} while (!isCorrect);
				filledCell++;
			}
			void BotMove()
			{
				Random random = new Random();
				int x, y;
				bool isCorrect = false;
				do
				{
					x = random.Next(3);
					y = random.Next(3);
					if (field[x, y] == 0)
					{
						field[x, y] = botChoice;
						isCorrect = true;
					}
				} while (!isCorrect);
				filledCell++;
			}
			void PickSymbol()
			{
				Console.Clear();
				ConsoleKeyInfo key;
				int choice = 0;
				Console.SetCursorPosition(gridX, gridY);
				string menu = "X|O";
				Console.Write(menu);
				do
				{
					key = Console.ReadKey(true);
					Console.Clear();
					switch (key.Key)
					{
						case ConsoleKey.Escape:
							Environment.Exit(0);
							break;
						case ConsoleKey.A:
						case ConsoleKey.LeftArrow:
							choice = 0;
							break;
						case ConsoleKey.D:
						case ConsoleKey.RightArrow:
							choice = 2;
							break;
						case ConsoleKey.Enter:
							if (choice == 0)
							{
								playerChoice = 1;
								botChoice = 2;
							}
							else
							{
								playerChoice = 2;
								botChoice = 1;
							}
							break;
					}
					for (int i = 0; i < 3; i++)
					{
						Console.SetCursorPosition(gridX + i, gridY);
						if (i == choice)
						{
							Console.BackgroundColor = ConsoleColor.White;
							Console.ForegroundColor = ConsoleColor.Black;
						}
						Console.Write(menu[i]);
						Console.ResetColor();
					}
				} while (key.Key != ConsoleKey.Enter);
			}
			public void Play()
			{
				do
				{
					PickSymbol();
					Console.Clear();
					int queue = 1;
					bool gameover = false;
					string winner;
					do
					{
						if (queue == playerChoice)
						{
							MakeMove();
						}
						else
						{
							BotMove();
						}
						//А тут проверка условия победы
						gameover = IsGameOver();
						//Меняем очередность хода
						queue = queue == 1 ? 2 : 1;

					} while (!gameover && filledCell != 9);
					PrintGrid();
                    if (filledCell == 9 && !gameover) winner = "Никто не";
					else if (queue == 1) winner = nought.ToString();
					else winner = cross.ToString();
                    Console.WriteLine($"{winner} победил.\nДля продолжения нажмите любую клавишу...");
					Console.ReadKey();
					CleanGame();
				} while (true);
			}
			bool IsGameOver()
			{
				for (int i = 0; i < winCombinations.Length; i++)
				{
					if (field[winCombinations[i][0], winCombinations[i][1]] != 0 &&
						field[winCombinations[i][0], winCombinations[i][1]] == field[winCombinations[i][2], winCombinations[i][3]] &&
						field[winCombinations[i][2], winCombinations[i][3]] == field[winCombinations[i][4], winCombinations[i][5]])
					{

                        return true;
					}
				}
				return false;
			}
		}
		static void Main(string[] args)
		{
			Game game = new Game();
			game.Play();
		}
	}
}
