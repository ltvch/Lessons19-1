using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190420_StructsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;

            p.X = 10;    // операция разыменования
            p.Y = 5;     // операция разыменования
            p.Color = ConsoleColor.Green;

            // инициализация значений полей структуры при объявлении переменной
            Point p2 = new Point() { X = 12, Y = 7, Color = ConsoleColor.Red };

            Point pCopy = p;    // копирование значений "по полям"
                                // p.X = pCopy.X
                                // p.Y = pCopy.Y

            pCopy.Y += 2;

            UI.Show(p);
            UI.Show(pCopy);

            Polyline pl;

            pl.Points = new Point[0];

            Add(ref pl, p);


            Console.ReadKey();
        }

        public static void Add(ref Polyline pl, Point p)
        {
            Array.Resize(ref pl.Points, pl.Points.Length + 1);
            pl.Points[pl.Points.Length - 1] = p;
        }
    }
}
