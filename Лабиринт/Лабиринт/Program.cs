using System;

namespace LabirintGame
{
    class Program
    {
        static char[,] lab;  // лабиринт
        static int playerX, playerY;  // где игрок
        static int exitX, exitY;  // где выход

        static void Main(string[] args)
        {
            int width = 11;  // ширина лабиринта
            int height = 11; // высота лабиринта

            lab = new char[,]
            {
                {'*','*','*','*','*','*','*','*','*','*','*' },
                {'*',' ',' ',' ',' ','*',' ',' ',' ',' ','*' },
                {'*','*','*','*',' ','*',' ','*','*',' ','*' },
                {'*',' ',' ',' ',' ','*',' ','*',' ',' ','*' },
                {'*','*',' ','*','*','*',' ','*',' ','*','*' },
                {'*',' ',' ',' ',' ',' ',' ','*',' ',' ','*' },
                {'*',' ','*','*','*','*','*','*','*',' ','*' },
                {'*',' ','*',' ',' ',' ',' ',' ',' ',' ','*' },
                {'*',' ','*','*','*',' ','*','*','*','*','*' },
                {'*',' ',' ',' ','*',' ',' ',' ',' ',' ','*' },
                {'*','*','*','*','*','*','*','*','*','*','*' },
            };

            playerX = 1;
            playerY = 1;
            exitX = width - 2;
            exitY = height - 2;


            while (true)
            {
                Console.Clear();
                PrintLab();
                Move();

                if (playerX == exitX && playerY == exitY)
                {
                    Console.Clear();
                    PrintLab();
                    Console.WriteLine("Слава богам, вы смогли выбраться из этого неверояяяятно сложного лабиринта");
                    break;
                }
            }
        }

        static void PrintLab()
        {
            for (int y = 0; y < lab.GetLength(0); y++)  //от 0 это строки,от 1 это типа столбц. хз, почему не работает ширина и высота, но ладно, главное, что теперь всё работает
            {
                for (int x = 0; x < lab.GetLength(1); x++)
                {
                    if (x == playerX && y == playerY)
                        Console.Write('C'); // игрок
                    else if (x == exitX && y == exitY)
                        Console.Write('E'); // выход
                    else
                        Console.Write(lab[y, x]);
                }
                Console.WriteLine();
            }
        }


        static void Move()
        {
            ConsoleKey key = Console.ReadKey(true).Key;

            int newX = playerX, newY = playerY;

            if (key == ConsoleKey.UpArrow && playerY > 0 && lab[playerY - 1, playerX] != '#')
                newY--;
            else if (key == ConsoleKey.DownArrow && playerY < lab.GetLength(0) - 1 && lab[playerY + 1, playerX] != '#')
                newY++;
            else if (key == ConsoleKey.LeftArrow && playerX > 0 && lab[playerY, playerX - 1] != '#')
                newX--;
            else if (key == ConsoleKey.RightArrow && playerX < lab.GetLength(1) - 1 && lab[playerY, playerX + 1] != '#')
                newX++;


            if (lab[newY, newX] != '*')
            {
                playerX = newX;
                playerY = newY;
            }
        }
    }
}