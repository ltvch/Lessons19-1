using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190525_ClassesDemo
{
    class UI
    {
        // Point p - ПЕРЕДАЧА ССЫЛКИ НА ОБЪЕКТ ПО ЗНАЧЕНИЮ
        public static void Show(Point p)
        {
            int oldX = Console.CursorLeft;
            int oldY = Console.CursorTop;

            Console.SetCursorPosition(p.GetX(), p.GetY());
            Console.Write('*');

            Console.SetCursorPosition(oldX, oldY);

            p.X -= 2;   // !!! измение оригинального объекта
        }

        public static void Show(PointRO p)
        {
            int oldX = Console.CursorLeft;
            int oldY = Console.CursorTop;

            Console.SetCursorPosition(p.GetX(), p.GetY());
            Console.Write('*');

            Console.SetCursorPosition(oldX, oldY);

            //p.X -= 2;   // !!! измение оригинального объекта
        }

        public static void Show(Polyline pl)
        {
            for (int i = 0; i < pl.Size; i++)
            {
                Point current = pl[i];

                Console.ForegroundColor = ConsoleColor.Green;
                //Show(pl.GetPointROByPosition(i));
                Show(current);
            }
        }
    }
}
