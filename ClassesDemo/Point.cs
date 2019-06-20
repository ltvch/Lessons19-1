using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190525_ClassesDemo
{
    class Point
    {
        #region PRIVATE FIELDS

        // !!! в классах поля могут инициализироваться при объявлении в классе

        private int _x = -1;
        private int _y = -1;
        public int []zzz ;

        #endregion

        #region Constructors

        // default
        public Point()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("before: ctor Point() _x = {0}, _y = {1}", _x, _y);

            _x = 1;
            _y = 1;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("after: ctor Point() _x = {0}, _y = {1}", _x, _y);
        }

        public Point(int val)
            : this(val, val)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("before: ctor Point() _x = {0}, _y = {1}", _x, _y);

            //_x = val;
            //_y = val;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ctor Point({0})", val);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("after: ctor Point() _x = {0}, _y = {1}", _x, _y);
        }

        public Point(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("before: ctor Point(_x = {0}, _y = {1})", _x, _y);

            _x = x;
            _y = y;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("after: ctor Point(_x = {0}, _y = {1})", _x, _y);
        }

        // COPY
        public Point(Point p)
            : this(p.X, p.Y)
        {
            //_x = p._x;
            //_y = p._y;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ctor Point(Point({0}, {1}))", p._x, p._y);
        }

        ~Point()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~Point()");
        //    Console.ReadKey();
        }                

        #endregion

        // factory
        public static Point Create(int x, int y)
        {



            return new Point(x, y);
        }


       
        #region Getters/setters

        public int GetX()
        {
            return _x;
        }

        public void SetX(int x)
        {
            // validation
            if (x < 0)
            {
                return;
            }

            _x = x;

            // point refresh
        }

        public int GetY()
        {
            return _y;
        }

        public void SetY(int y)
        {
            _y = y;
        }

        #endregion


        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                // validation
                if (value < 0)
                {
                    return;
                }

                _x = value;

                // point refresh
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                // validation
                if (value < 0)
                {
                    return;
                }

                _y = value;

                // point refresh
            }
        }

    }
}
