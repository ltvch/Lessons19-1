using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190518_IncapulationDemo
{
    class UI
    {
        public static void Show(Point p)
        {
            int oldX = Console.CursorLeft;
            int oldY = Console.CursorTop;

            Console.SetCursorPosition(p.GetX(), p.GetY());            
            Console.Write('*');

            Console.SetCursorPosition(oldX, oldY);
        }
    }
}
