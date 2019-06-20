using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190601_InheritanceDemoII
{
    class Program
    {
        static void Main(string[] args)
        {
            A objA = new A();
            B objB = new B();
            C objC = new C();


            objA.f();

            Console.WriteLine();

            // 1. использование метода-обертки
            objB.f();
            objB.fFromA();

            // 2. ссылка на базовый класс может содержать экземпляр производного класса
            A objBasA = objB;
            objBasA.f();

            Console.WriteLine();

            objC.f();

            Console.ReadKey();
        }
    }
}
