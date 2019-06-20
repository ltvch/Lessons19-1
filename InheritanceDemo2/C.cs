using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190601_InheritanceDemoII
{
    // sealed - запрещает класс С для дальнейшего наследования
    sealed class C : B
    {
        public void f()
        {
            Console.WriteLine("C.f()");
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
