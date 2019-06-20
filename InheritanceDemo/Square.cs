using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190601_InheritanceDemo
{
    class Square : Point
    {
        // _x, _y - координата верхнего левого угла

        #region Private fields

        private int _a;    // длина стороны квадрата

        #endregion

        public Square(int x, int y, int a)
            : base(x, y)
        {
            //_x = x;
            //_y = y;
            _a = a;
#if DEBUG
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ctor Square({0},{1},{2})", x, y, a);
#endif
        }

        public int Size
        {
            get
            {
                return _a;
            }
        }

        public void Resize(float scale)
        {
            _a = (int)(_a * scale);
        }

        ~Square()
        {
//#if DEBUG
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~Square(): _x = {0}, _y = {1}, _a = {2}", _x, _y, _a);
//#endif
            //    Console.ReadKey();
        }
    }
}
