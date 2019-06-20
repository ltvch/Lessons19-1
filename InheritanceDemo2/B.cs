using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190601_InheritanceDemoII
{
    class B : A
    {
        public void f()
        {
            Console.WriteLine("B.f()");
        }

        public void fFromA()
        {
            ConsoleColor oldColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("B.fFromA()");
            base.f();

            Console.ForegroundColor = oldColor;
        }
    }
}
