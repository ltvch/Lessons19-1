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
            D objD = new D();


            objA.f();

            Console.WriteLine();

            // 1. использование метода-обертки
            objB.f();
            objB.fFromA();

            // 2. ссылка на базовый класс может содержать экземпляр производного класса
            A objBasA = objB;    // upcast
            objBasA.f();

            Console.WriteLine();

            objC.f();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("TestIsAs1:");

            TestIsAs1(objC);    // upcast C -> object
            TestIsAs1(objB);    // upcast B -> object
            TestIsAs1(objA);    // upcast A -> object

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("TestIsAs2:");

            TestIsAs2(objC);    // upcast C -> object
            TestIsAs2(objB);    // upcast B -> object
            TestIsAs2(objA);    // upcast A -> object

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("TestIsAs4:");

            TestIsAs4(objC);    // upcast C -> object
            TestIsAs4(objB);    // upcast B -> object
            TestIsAs4(objA);    // upcast A -> object
            TestIsAs4(null);    //  upcast null reference -> object


            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("TestIsAsMyVirtual:");

            TestIsAsMyVirtual(objC);    // upcast C -> object
            Console.WriteLine();
            TestIsAsMyVirtual(objB);    // upcast B -> object
            Console.WriteLine();
            TestIsAsMyVirtual(objA);    // upcast A -> object

            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("VIRTUAL METHODS:");
            TestVirtual(objD);
            Console.WriteLine();
            TestVirtual(objC);
            Console.WriteLine();
            TestVirtual(objB);
            Console.WriteLine();
            TestVirtual(objA);
            Console.WriteLine();
            
            Console.ReadKey();
        }

        public static void TestIsAs1(object obj)    // 
        {
            if (obj is B)
            {
                //B o1 = (B)obj;    // downcast

                //o1.f();    // f from B

                ((B)obj).f();
            }
            else
            {
                Console.WriteLine("{0} - isn't B", obj);
            }
        }

        public static void TestIsAs2(object obj)    
        {
            C o2 = obj as C;    // downcast

            if (o2 != null)
            {
                o2.f();    // f from C
            }
            else
            {
                Console.WriteLine("{0} - isn't C", obj);
            }
        }

        public static void TestIsAs3Wrong(object obj)
        {
            if (obj is B)    // RTTI (1)
            {
                B o1 = obj as B;    // RTTI (2) // downcast 

                o1.f();    // f from B
            }
            else
            {
                Console.WriteLine("{0} - isn't B", obj);
            }
        }

        public static void TestIsAs4(object obj)
        {
            if (obj is A)    // RTTI
            {
                A o1 = (A)obj;    // downcast 

                o1.f();    // f from B
            }
            else
            {
                Console.WriteLine("{0} - isn't A", obj);
            }
        }

        public static void TestIsAsMyVirtual(object obj)
        {
            if (obj is C)    // RTTI
            {
                C o3 = (C)obj;    // downcast 

                o3.f();    // f from B
            }
            else
            {
                if (obj is B)    // RTTI 
                {
                    B o2 = (B)obj;    // downcast 

                    o2.f();    // f from B
                }
                else
                {
                    if (obj is A)    // RTTI 
                    {
                        A o1 = (A)obj;    // downcast 

                        o1.f();    // f from B
                    }                    
                }
            }
        }

        public static void TestVirtual(Base0 obj)
        {            
            obj.fVirt();
        }
    }
}
