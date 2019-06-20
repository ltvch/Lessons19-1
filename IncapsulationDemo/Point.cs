using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190518_IncapulationDemo
{
    struct Point
    {
        #region PRIVATE FIELDS

        private int _x;

        private int _y;

        #endregion

        #region Constructors

        // default (!!! в структурах реализуется самим .NET)
        //public Point()
        //{

        //}

        public Point(int val) : this(val, val)
        {
            //_x = val;
            //_y = val;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ctor Point({0})", val);
        }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ctor Point({0}, {1})", x, y);
        }

        // COPY
        public Point(Point p) : this(p.X, p.Y)
        {
            //_x = p._x;
            //_y = p._y;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ctor Point(Point({0}, {1}))", p._x, p._y);
        }

        #endregion

        // factory
        public static Point Create(int x, int y)
        {
            return new Point() { _x = x, _y = y };
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
