using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190420_MatrixDemoPartII
{
    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[][][] с;  //---?
            int[,][] weater;  //---?

            int[][] m;

            m = new int[5][];

            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new int[i + 1 * 2];
            }

            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                {
                    m[i][j] = rnd.Next(-1000, 1000);
                }
            }

            Print(m, 5, 3, 3);

            //int[][] mCopy = m;    // !!! копирование ссылок

            //int[][] mCopy = (int[][])m.Clone();    // !!! поверхностное копирование
            int[][] mCopy = new int[m.Length][];    // !!! выделение пустого массива ссылок

            // полное копирование
            for (int i = 0; i < mCopy.Length; i++)
            {
                mCopy[i] = (int[])m[i].Clone();
            }

            mCopy[2][2] = 7777;

            Console.ReadKey();

            Console.Clear();
            
            Print(m, 5, 3, 3, ConsoleColor.Green);

            Print(mCopy, 5, 33, 3, ConsoleColor.Red);

            // обмен двух строк (1 <---> 3)
            int[] tmp = m[1];
            m[1] = m[3];
            m[3] = tmp;

            Console.ReadKey();

            Console.Clear();

            Print(m, 5, 3, 3, ConsoleColor.Cyan);

            Print(mCopy, 5, 33, 3, ConsoleColor.Green);

            Console.ReadKey();
        }

        private static void Print(int[][] m, int size, int offsetX, int offsetY, ConsoleColor color = ConsoleColor.White)
        {

           Console.ForegroundColor = color;

           for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                {
                    Console.SetCursorPosition(j * size + offsetX, i + offsetY);
                    Console.Write("{0, 5}", m[i][j]);
                }
            }
        }

    }
}
