using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190601_InheritanceDemo
{
    class UI
    {
        public static void Show(Square s)
        {
            Console.BackgroundColor = ConsoleColor.Green;

            for (int i = 0; i < s.Size; i++)
            {
                for (int j = 0; j < s.Size; j++)
			    {
                    Console.SetCursorPosition(s.X + i, s.Y + j);
                    Console.Write(' ');
			    }                
            }
        }
    }
}
