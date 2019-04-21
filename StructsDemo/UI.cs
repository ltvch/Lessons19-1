using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190420_StructsDemo
{
    class UI
    {
        public static void Show(Point p)
        {
            Console.SetCursorPosition(p.X, p.Y);
            Console.ForegroundColor = p.Color;
            Console.Write('*');
        }
    }
}
