using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190706_ImplicitInterfacesImplDemo
{
    class C : I1, I2
    {
        public void f()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("C.f()");
        }

        void I1.f()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("I1.f()");
        }

        void I2.f()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("I2.f()");
        }
    }
}
