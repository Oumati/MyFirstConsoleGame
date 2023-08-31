using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleGame
{
	internal class Program
	{
		static void Main(string[] args)
		{

			char t = 'T';
			//DungeonMap
			char[,] map =
			{
				{'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','T',' ',' ','#','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ','#','#','#','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ','#',' ','X',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ','#','H','H','H','H','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','F',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
				{'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#', }
			};


			Console.CursorVisible = false;
			int userX = 6, userY = 6;
			bool DoorOpen = false;
			char[] bag = new char[1];

			while (true)
			{

				//MapOnline
				Console.SetCursorPosition(0, 0);
				Console.ForegroundColor = ConsoleColor.DarkBlue;
				for (int i = 0; i < map.GetLength(0); i++)
				{
					for (int j = 0; j < map.GetLength(1); j++)
					{

						if (map[i, j] == 'H')
						{
							Console.ForegroundColor = ConsoleColor.Red;
						}
						else if (map[i, j] == 'U')
						{
							Console.ForegroundColor = ConsoleColor.Green;
						}
						else if (map[i, j] == 'X')
						{
							Console.ForegroundColor = ConsoleColor.DarkYellow;
						}
						else if (map[i, j] == 'F')
						{
							Console.ForegroundColor = ConsoleColor.Blue;
						}
						else
						{
							Console.ForegroundColor = ConsoleColor.DarkGray;
						}
						Console.Write(map[i, j]);

					}
					Console.WriteLine();
				}

				//Bag
				Console.SetCursorPosition(0, 25);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("Сумка: ");
				for (int i = 0; i < bag.Length; i++)
				{
					Console.Write(bag[i] + " ");
				}



				for (int i = 0; i < map.GetLength(0); i++)
				{
					for (int j = 0; j < map.GetLength(1); j++)
					{

					}
				}

				//Player
				Console.SetCursorPosition(userY, userX);
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.Write("@");

				//PlayerMove
				ConsoleKeyInfo userMove = Console.ReadKey();
				switch (userMove.Key)
				{
					case ConsoleKey.UpArrow:
						if (map[userX - 1, userY] != '#' && map[userX - 1, userY] != 'H')
						{
							userX--;
						}
						break;

					case ConsoleKey.DownArrow:
						if (map[userX + 1, userY] != '#' && map[userX + 1, userY] != 'H')
						{
							userX++;
						}
						break;

					case ConsoleKey.LeftArrow:
						if (map[userX, userY - 1] != '#' && map[userX, userY - 1] != 'H')
						{
							userY--;
						}
						break;

					case ConsoleKey.RightArrow:
						if (map[userX, userY + 1] != '#' && map[userX, userY + 1] != 'H')
						{
							userY++;
						}
						break;
				}



				//BagWork
				if (map[userX, userY] == 'X')
				{
					map[userX, userY] = 'O';
					char[] tempBag = new char[bag.Length + 1];
					for (int i = 0; i < bag.Length; i++)
					{
						tempBag[i] = bag[i];
					}
					tempBag[tempBag.Length - 1] = 'X';
					bag = tempBag;

				}

				if (map[userX, userY] == 'F' && bag[bag.Length - 1] == 'X')
				{
					Console.Clear();
					Console.WriteLine("Ты Выиграл");
					Console.ReadLine();
					break;
				}



				if (map[userX, userY] == 'T')
				{
					if (DoorOpen == false)
					{

						for (int i = 0; i < map.GetLength(0); i++)
						{
							for (int j = 0; j < map.GetLength(1); j++)
							{
								if (map[i, j] == 'H')
								{
									map[i, j] = 'U';
									DoorOpen = true;
								}
							}

						}

					}

					else if (DoorOpen == true)
					{
						for (int i = 0; i < map.GetLength(0); i++)
						{
							for (int j = 0; j < map.GetLength(1); j++)
							{
								if (map[i, j] == 'U')
								{
									map[i, j] = 'H';
									DoorOpen = false;
								}
							}

						}
					}

				}


				Console.Clear();

			}

		}
	}
}
