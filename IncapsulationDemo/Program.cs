using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190518_IncapulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();    // p1._x = 0;    p1._y = 0;

            p1.SetX(12);
            p1.SetY(9);

            UI.Show(p1);

            Point p2 = Point.Create(2, 5);    // p1._x = 2;    p1._y = 5;

            UI.Show(p2);

            Console.ReadKey();
            Console.Clear();

            p1.X = 19;
            p2.Y = 10;

            int k = p2.Y;

            UI.Show(p1);
            UI.Show(p2);

            Point p5 = new Point(8);

            Console.ForegroundColor = ConsoleColor.Red;
            UI.Show(p5);

            Point p6 = new Point(18, 8);

            Console.ForegroundColor = ConsoleColor.Green;
            UI.Show(p6);

            Point p6Copy = p6;
            p6Copy.Y += 2;

            Point p5Copy = new Point(p5);
            p5Copy.X *= 2;


            Polyline pl1 = new Polyline(p1, p2, p5, p5Copy);

            Polyline pl1Copy = pl1;    // ??? копирование ссылки на массив точек :(
 
            Polyline pl1Copy1 = new Polyline(pl1);   // правильное создание копии ломанной линии

            Console.ReadKey();
        }
    }
}
