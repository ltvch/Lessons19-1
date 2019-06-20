using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190508_ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Direction d = Direction.NoDirection;

            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;

            int xFood = Console.WindowWidth / 2;
            int yFood = 1;


            ConsoleKey currentKey = ConsoleKey.Spacebar;

            ulong iteration = 0;

            do
            {
                if (Console.KeyAvailable)    // если нажата клавиша
                {
                    // считываем нажатую клавишу
                    currentKey = Console.ReadKey(true).Key;    // считываем нажатый символ без эха на экран

                    switch (currentKey)
                    {
                        case ConsoleKey.LeftArrow:
                            d = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            d = Direction.Right;
                            break;
                        case ConsoleKey.UpArrow:
                            d = Direction.Top;
                            break;
                        case ConsoleKey.DownArrow:
                            d = Direction.Bottom;
                            break;
                    }
                }

                Console.SetCursorPosition(x, y);
                Console.Write(' ');

                // изменение текущей координаты "игрового объекта"
                switch (d)
                {                   
                    case Direction.Left:
                        --x;
                        break;
                    case Direction.Right:
                        ++x;
                        break;
                    case Direction.Top:
                        --y;
                        break;
                    case Direction.Bottom:
                        ++y;
                        break;
                    case Direction.NoDirection:
                    default:
                        break;
                }

                // отображение "игрового объекта" в новой позиции
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write('#');

                #region FOOD

                if (++iteration % 3 == 0)
                {
                    Console.SetCursorPosition(xFood, yFood);
                    Console.Write(' ');

                    if (yFood < Console.WindowHeight - 1)
                    {
                        ++yFood;
                    }
                    else
                    {
                        yFood = 1;
                    }

                    Console.SetCursorPosition(xFood, yFood);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('|');
                }

                #endregion


                System.Threading.Thread.Sleep(100);
            } while (currentKey != ConsoleKey.Escape);

        }
    }
}
