using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190413_MatrixDemo
{
    class Program
    {
        static Random rnd = new Random();    // генератор случайных чисел (!!! инициализация от текущего времени)

        const int N = 8;
        const int M = 4;

        static void Main(string[] args)
        {
            Console.WindowWidth = 150;

            int[,] m1;

            m1 = new int[N, M];

            Console.WriteLine("m1.Length: {0}", m1.Length);

            Console.WriteLine("m1.GetLength(0): {0}", m1.GetLength(0));
            Console.WriteLine("m1.GetLength(1): {0}", m1.GetLength(1));

            // m1.GetLength(0) - кол-во строк
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                // m1.GetLength(1) - sкол-во столбцов
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    m1[i, j] = rnd.Next(-1000, 1000);    
                }
            }

            //// m1.GetLength(0) - кол-во строк
            //for (int i = 0; i < m1.GetLength(0); i++)
            //{
            //    // m1.GetLength(1) - sкол-во столбцов
            //    for (int j = 0; j < m1.GetLength(1); j++)
            //    {                    
            //        Console.Write("{0, 7} ", m1[i, j]);
            //    }
            //    Console.WriteLine();
            //}
           

            int[,] m1T = GetTransp(m1);


            Print(m1, 7, 0, 3);
            Print(m1T, 7, 45, 3);

            int[] source = new int[N * M];

            for (int i = 0; i < source.Length; i++)
            {
                source[i] = rnd.Next(-100, 100);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Source");
            Print(source);

            int[,] result = GetMatrVer1(source, N, M);

            Console.ForegroundColor = ConsoleColor.Green;

            Print(result, 7, 0, 13);

            Console.ReadKey();
        }

        private static void Print(int[,] m1, int size, int offsetX, int offsetY)
        {

            Console.ForegroundColor = ConsoleColor.Red;

            // m1.GetLength(0) - кол-во строк
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                // m1.GetLength(1) - sкол-во столбцов
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j * size + offsetX, i + offsetY);
                    Console.Write("{0, 5}", m1[i, j]);
                }
            }
        }

        private static int[,] GetTransp(int[,] matr)
        {

            int[,] result = new int[matr.GetLength(1), matr.GetLength(0)];

            // m1.GetLength(0) - кол-во строк
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                // m1.GetLength(1) - sкол-во столбцов
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    result[j, i] = matr[i, j];
                }
            }

            return result;
        }


        private static int[,] GetMatrVer1(int[] v, int n, int m)
        {

            int[,] result = new int[n, m];

            int l = 0;

            // m1.GetLength(0) - кол-во строк
            for (int i = 0; i < result.GetLength(0); i++)
            {
                if (i %2 == 0)
                {
                    // m1.GetLength(1) - sкол-во столбцов
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        result[i, j] = v[l++];
                    }    
                }
                else
                {
                    for (int j = result.GetLength(1) - 1; j >= 0; j--)
                    {
                        result[i, j] = v[l++];
                    }
                }
                
            }

            return result;
        }

        public static void Print(int[] vect)
        {
            if (vect == null)
            {
                return;
            }

            for (int i = 0; i < vect.Length; i++)
            {
                Console.Write("{0}\t", vect[i]);
            }
            Console.WriteLine();
        }

    }
}
