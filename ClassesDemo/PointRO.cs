using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190525_ClassesDemo
{
    class PointRO
    {
        public PointRO(Point p)
        {
            _p = p;
        }

        public int GetX()
        {
            return _p.GetX();
        }

        public int GetY()
        {
            return _p.GetY();
        }

        private Point _p;
    }
}
