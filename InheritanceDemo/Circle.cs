using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190601_InheritanceDemo
{
    // Circle - child
    // Point - parent
    class Circle : Point
    {
        public Circle()
            : base(1, 1)  // - вызов конструктора базового класса с 2-мя параметрами
        {
#if DEBUG
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ctor Circle()");
#endif
        }

        ~Circle()
        {
//#if DEBUG
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("~Circle()");
//#endif
            //    Console.ReadKey();
        }
    }
}
