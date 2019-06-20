using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190601_InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();

//            c1.

            Console.WriteLine();

            Square s1 = new Square(21, 13, 5);

            Console.WriteLine(s1);    // call object.ToString() for s1
            
            UI.Show(s1);

            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            s1.Move(2, 5);

            s1.Resize(1.5f);

            UI.Show(s1);

            //for (int i = 0; i < 1000000; i++)
            //{
            //    Circle c2 = new Circle();

            //    Square s2 = new Square(i, i, i);
            //}


            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

        }
    }
}
