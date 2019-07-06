using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190706_ImplicitInterfacesImplDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            C obj = new C();            

            I1 ir1 = obj;

            I2 ir2 = obj;

            obj.f();
            ir1.f();
            ir2.f();

            Console.ReadKey();
        }
    }
}
