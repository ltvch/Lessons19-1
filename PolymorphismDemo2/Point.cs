using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190601_InheritanceDemo
{
    class Point
    {
        #region PROTECTED FIELDS

        // !!! в классах поля могут инициализироваться при объявлении в классе

        protected int _x = -1;
        protected int _y = -1;

        #endregion

        #region Constructors

        // default
//        public Point()
//        {
//#if DEBUG
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("before: ctor Point() _x = {0}, _y = {1}", _x, _y);
//#endif
//            _x = 1;
//            _y = 1;

//#if DEBUG
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.WriteLine("after: ctor Point() _x = {0}, _y = {1}", _x, _y);
//#endif
//        }

        public Point(int val)
            : this(val, val)
        {
#if DEBUG
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("before: ctor Point() _x = {0}, _y = {1}", _x, _y);
#endif

            //_x = val;
            //_y = val;

#if DEBUG
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ctor Point({0})", val);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("after: ctor Point() _x = {0}, _y = {1}", _x, _y);
#endif
        }

        public Point(int x, int y)
        {
#if DEBUG
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("before: ctor Point(_x = {0}, _y = {1})", _x, _y);
#endif

            _x = x;
            _y = y;

#if DEBUG
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("after: ctor Point(_x = {0}, _y = {1})", _x, _y);
#endif
        }

        // COPY
        public Point(Point p)
            : this(p.X, p.Y)
        {
            //_x = p._x;
            //_y = p._y;
#if DEBUG
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ctor Point(Point({0}, {1}))", p._x, p._y);
#endif
        }

        ~Point()
        {
//#if DEBUG
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~Point()");
//#endif
                //Console.ReadKey();
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

        public void Move(int dx, int dy)
        {
            // менее производительный
            //X += dx;
            //Y += dy;

            // более производительный (нет дополнительных вызовов методов set/get )
            _x += dx;
            _y += dy;
        }


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
