using System;
using System.Collections/*.Generic*/;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190622_InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintContainer(null);    // runtime error

            DoubleContainer c1 = new DoubleContainer();

            PrintContainer(c1);

            IntContainer c2 = new IntContainer();

            PrintContainer(c2);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("foreach:");
            foreach (object item in c1)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("foreach:");
            foreach (object item in c2)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine();
            Console.WriteLine("IEnumerator + while:");
            // Как  работает foreach
            IEnumerator iter = c2.GetEnumerator();
            while (iter.MoveNext())
            {
                Console.Write("{0}\t", iter.Current);
            }
            Console.WriteLine();

            int[] abc = new int[] { 2, -2, 3, -3 };
            Console.WriteLine("foreach for array:");
            foreach (object item in abc)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        // 2 (3). use of interface IContainer (используем контракт)
        public static void PrintContainer(IContainer c)
        {
            for (int i = 0; i < c.Count; i++)
            {
                Console.Write("{0}\t", c[i]);
            }
            Console.WriteLine();
        }
    }
}
