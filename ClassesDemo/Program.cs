using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190525_ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Func();

            Point p4 = new Point(14);

            //Point p4Copy = p4;    // копирование ссылки!!!
            Point p4Copy = new Point(p4);    // копирование ссылки!!!

            p4Copy.X = 6;

            Console.ReadKey();
            Console.Clear();

            // !!! небезопасный или ресурсоёмкий вариант
            //UI.Show(new Point(p4));
            //UI.Show(new Point(p4Copy));

            //Console.ReadKey();
            //Console.Clear();

            //UI.Show(new Point(p4));
            //UI.Show(new Point(p4Copy));

            //Console.ReadKey();
            //Console.Clear();

            //UI.Show(new Point(p4));
            //UI.Show(new Point(p4Copy));


            UI.Show(new PointRO(p4));
            UI.Show(new PointRO(p4Copy));

            Console.ReadKey();
            Console.Clear();

            UI.Show(new PointRO(p4));
            UI.Show(new PointRO(p4Copy));

            Console.ReadKey();
            Console.Clear();

            UI.Show(new PointRO(p4));
            UI.Show(new PointRO (p4Copy));

            Console.WriteLine("A lot of point: ...");
            Console.ReadKey();

            //for (int i = 0; i < 1000000; i++)
            //{
            //    Point p5 = new Point(i + 1);
            //}

            Polyline pl1 = new Polyline(3);

            pl1.Add(new Point(2, 2));
            pl1.Add(new Point(21, 12));
            pl1.Add(new Point(3, 3));

            pl1.Add(new Point(4, 4))
               /*.Add(new Point(5, 6))
               .Add(new Point(7, 7))*/;

            //if (pl1.Add(new Point(4, 4)).Add(new Point(5, 6)).Capacity > 2)
            //{
            //}

            //Polyline pl1Copy = pl1;    // ? reference copy

            Polyline pl1Copy = new Polyline(pl1);

            Console.Clear();            

            UI.Show(pl1Copy);

            Console.ReadKey();
        }

        public static void Func()
        {
            Point p1 = null;

            Console.WriteLine(p1);

            Point p2 = new Point();

            Console.WriteLine();

            Point p3 = new Point(3, 5);

            Console.WriteLine();          
        }
    }
}
